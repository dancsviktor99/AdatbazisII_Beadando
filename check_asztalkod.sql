CREATE OR REPLACE FUNCTION sf_check_asztalkod
(
    p_asztalkod in jatekok.asztalkod%type
)
RETURN INT
DETERMINISTIC

AS
    v_asztalkod_char char(1);
    v_i int;
BEGIN
    IF p_asztalkod is NULL THEN
        return 0;
    END IF;
    
    IF LENGTH(TRIM(p_asztalkod)) = 6 then
        v_i := 1;
        WHILE v_i <= 6 LOOP
            v_asztalkod_char := substr(p_asztalkod, v_i, 1);
        IF NOT (ASCII('A') <= ASCII(v_asztalkod_char) AND ASCII(v_asztalkod_char) <= ASCII('Z') OR ASCII('0') <= ASCII(v_asztalkod_char) AND ASCII(v_asztalkod_char) <= ASCII('9')) THEN
            return 0;
        END IF;
        
        v_i := v_i + 1;
        END LOOP;
        
        return 1;
    END IF;
    
    return 0;

END sf_check_asztalkod;
        