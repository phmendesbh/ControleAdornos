SELECT p.id, p.descricao, c.id, c.descricao, c.valorARGB
FROM palavra p
INNER JOIN cor c on
	c.id = p.cor_id
ORDER BY p.descricao