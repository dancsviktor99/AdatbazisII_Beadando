CREATE OR REPLACE PROCEDURE sp_InsertKrupiek
(
    p_nev in krupiek.nev%type
)
authid definer
AS
    v_id int;
BEGIN
    select max(id) into v_id from krupiek;
        if v_id is null then
            v_id := 0;
        end if;
    v_id := v_id + 1;
    
    insert into krupiek(id, nev)
    values(v_id, p_nev);
END sp_InsertKrupiek;
