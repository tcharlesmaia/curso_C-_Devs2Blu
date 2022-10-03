
insert into genero (nome)
values ('ação'), ('drama'), ('fantasia'), ('ficacao');
select * from genero;

insert into classificacao (label, numlabel, observacao)
values ('livre', 0, 'exibição em qualquer horário'),
	('10 anos', 10, 'exibição em qualquer horário'),
    ('12 anos', 12, 'a artir das 20hs'),
    ('15 anos', 15, 'a artir das 21hs'),
    ('18 anos', 18, 'a artir das 23hs');