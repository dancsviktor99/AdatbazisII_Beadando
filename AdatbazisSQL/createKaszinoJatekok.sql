DROP TABLE jatekok;

CREATE TABLE jatekok(
    asztalkod char(6) not null,
    jatekasztalneve char(1) not null,
    gyarto varchar(2) not null,
    asztallimit int not null,
    krupie_id int not null,
    asztal_datuma date not null,
    jatektipusa varchar2(200) not null,
    
    constraint pk_asztalkod primary key(asztalkod),
    constraint ch_jatekok_jatekasztalneve check(jatekasztalneve in ('A', 'B', 'C', 'D')),
    constraint fk_krupiek foreign key(krupie_id) references krupiek(id)
    
);