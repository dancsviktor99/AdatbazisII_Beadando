CREATE OR REPLACE PROCEDURE spInsert_KaszinoJatekok(
    p_asztalkod in jatekok.asztalkod%type,
    p_jatekasztalneve in jatekok.jatekasztalneve%type,
    p_gyarto in jatekok.gyarto%type,
    p_asztallimit in jatekok.asztallimit%type,
    p_krupie in jatekok.krupie_id%type,
    p_asztal_datuma in jatekok.asztal_datuma%type,
    p_jatektipusa in jatekok.jatektipusa%type,
    
    p_out_rowcnt out int
)
authid definer
AS
    v_check_asztalkod int;
    v_krupie_id int;
BEGIN
        p_out_rowcnt := 0;
    
        v_krupie_id := sf_getKrupiekId(p_krupie);
    if v_krupie_id is null then
        sp_InsertKrupiek(p_krupie);
        v_krupie_id := sf_getKrupiekId(p_krupie);
    end if;
    v_check_asztalkod := sf_check_asztalkod(p_asztalkod);
        
        IF v_check_asztalkod = 1 THEN
            INSERT INTO jatekok
                (asztalkod, jatekasztalneve, gyarto, asztallimit, krupie_id, asztal_datuma, jatektipusa)
            VALUES
                (p_asztalkod, p_jatekasztalneve, p_gyarto, p_asztallimit, p_krupie_id, p_asztal_datuma, p_jatektipusa);
        p_out_rowcnt := SQL%rowcount;
            COMMIT;
        END IF;
END spInsert_KaszinoJatekok;