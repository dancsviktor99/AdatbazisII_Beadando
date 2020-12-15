SET SERVEROUTPUT ON;

DECLARE
    v_call_asztalkod int;
    v_asztalkod jatekok.asztalkod%type := 'AB12C3';
BEGIN
v_call_asztalkod := sf_check_asztalkod(v_asztalkod);
    IF v_call_asztalkod = 1 THEN
        DBMS_OUTPUT.PUT_LINE('Az alábbi asztalkód helyes: '||v_asztalkod);
    ELSE
        DBMS_OUTPUT.PUT_LINE('Az alábbi asztalkód helytelen: '||v_asztalkod);
    END IF;
END;