select
id,
nome,
datanascimento,
status
from 
pessoa;

select id, id_pessoa, loging, senha, status from usuario;
select p.id as id_pessoa, u.id_pessoa, p.idade, u.senha, u.status
 from pessoa as p
join usuario as u
on p.id = u.id_pessoa;
select * from pessoa where datanascimento < '1998-01-01';