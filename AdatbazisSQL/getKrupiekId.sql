CREATE OR REPLACE FUNCTION sf_getKrupiekId
(
    p_nev in krupiek.nev%TYPE
)
RETURN INT
DETERMINISTIC

AS
    temp int;
    temp_cnt int;
BEGIN
    SELECT COUNT(*) INTO temp_cnt FROM krupiek WHERE nev = p_nev;
    
    IF temp_cnt = 0 THEN
            return null;
    ElSE
            SELECT id INTO temp FROM krupiek WHERE nev = p_nev;
    END IF;
    
    return temp;
END sf_getKrupiekId;