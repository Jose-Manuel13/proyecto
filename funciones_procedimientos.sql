-- =====================================================
-- ACTIVIDAD: FUNCIONES Y PROCEDIMIENTOS EN POSTGRESQL
-- =====================================================

-- 1. CREACIÓN DE TABLA
CREATE TABLE customers (
    id_user SERIAL PRIMARY KEY,
    fname VARCHAR NOT NULL,
    lname VARCHAR NOT NULL,
    balance NUMERIC(10, 2) NOT NULL
);

-- 2. DATOS INICIALES
INSERT INTO customers (fname, lname, balance)
VALUES
    ('Juan', 'Santana', 10000),
    ('Pablo', 'Sánchez', 500),
    ('María', 'Sosa', 500);

-- 3. CONSULTA INICIAL
SELECT * FROM customers;


-- =====================================================
-- PARTE 1: FUNCIÓN
-- =====================================================

CREATE OR REPLACE FUNCTION capturar_balance(p_id_user INT)
RETURNS NUMERIC
LANGUAGE plpgsql
AS $$
DECLARE
    current_balance NUMERIC;
BEGIN
    SELECT balance
    INTO current_balance
    FROM customers
    WHERE id_user = p_id_user;

    IF current_balance IS NULL THEN
        RAISE EXCEPTION 'Este usuario no existe';
    END IF;

    RETURN current_balance;
END;
$$;

-- Prueba de función
SELECT capturar_balance(1);

-- Prueba de usuario inexistente
SELECT capturar_balance(99);


-- =====================================================
-- PARTE 2: PROCEDIMIENTO
-- =====================================================

CREATE OR REPLACE PROCEDURE transferir_dinero(
    origin INT,
    destination INT,
    amount NUMERIC
)
LANGUAGE plpgsql
AS $$
DECLARE
    origin_balance NUMERIC;
    destination_exists BOOLEAN;
BEGIN

    IF amount <= 0 THEN
        RAISE EXCEPTION 'El monto debe ser mayor que cero';
    END IF;

    SELECT balance
    INTO origin_balance
    FROM customers
    WHERE id_user = origin;

    IF origin_balance IS NULL THEN
        RAISE EXCEPTION 'El usuario origen no existe';
    END IF;

    SELECT EXISTS (
        SELECT 1
        FROM customers
        WHERE id_user = destination
    )
    INTO destination_exists;

    IF NOT destination_exists THEN
        RAISE EXCEPTION 'El usuario destino no existe';
    END IF;

    IF origin_balance < amount THEN
        RAISE EXCEPTION 'Fondos insuficientes';
    END IF;

    UPDATE customers
    SET balance = balance - amount
    WHERE id_user = origin;

    UPDATE customers
    SET balance = balance + amount
    WHERE id_user = destination;

    RAISE NOTICE 'Transferencia realizada correctamente';

END;
$$;


-- =====================================================
-- PRUEBA DE TRANSFERENCIA EXITOSA
-- =====================================================

SELECT * FROM customers;

CALL transferir_dinero(1, 2, 1000);

SELECT * FROM customers;


-- =====================================================
-- PRUEBA DE FONDOS INSUFICIENTES
-- =====================================================

CALL transferir_dinero(2, 3, 2000);


-- =====================================================
-- PRUEBA DE USUARIO ORIGEN INEXISTENTE
-- =====================================================

CALL transferir_dinero(99, 2, 100);


-- =====================================================
-- PRUEBA DE USUARIO DESTINO INEXISTENTE
-- =====================================================

CALL transferir_dinero(1, 99, 100);


-- =====================================================
-- PRUEBA DE ROLLBACK
-- =====================================================

BEGIN;

UPDATE customers
SET balance = balance - 500
WHERE id_user = 1;

UPDATE customers
SET balance = balance + 500
WHERE id_user = 3;

SELECT * FROM customers;

ROLLBACK;

SELECT * FROM customers;


-- =====================================================
-- PRUEBA DE COMMIT
-- =====================================================

BEGIN;

UPDATE customers
SET balance = balance - 200
WHERE id_user = 1;

UPDATE customers
SET balance = balance + 200
WHERE id_user = 3;

COMMIT;

SELECT * FROM customers;