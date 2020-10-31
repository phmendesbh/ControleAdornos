CREATE TABLE IF NOT EXISTS palavra
	(id INTEGER PRIMARY KEY, 
	descricao VARCHAR(15), 
	cor_id INTEGER,
	material_id INTEGER,
	
	FOREIGN KEY(cor_id) REFERENCES cor(id),
	FOREIGN KEY(material_id) REFERENCES material(id))