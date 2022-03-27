#------------------------------------------------------------------------------------------------------------------------------------------------
#Produto
DELIMITER //
CREATE PROCEDURE pr_insert_produto(
	descricao varchar(100),
	classe varchar(45),
	status varchar(45), 
	preco_compra decimal(10,0), 
	compra_imposto decimal(10,0), 
	margem_lucro decimal(10,0), 
	preco_venda decimal(10,0), 
	estoque_disponivel decimal(10,0), 
	estoque_min decimal(10,0),
	estoque_max decimal(10,0),
	estoque_vinculado decimal(10,0),
	estoque_previsto decimal(10,0), 
	descricoes_detalhadas varchar(1000), 
	observacoes varchar(1000),
    codigo_tipo varchar(45),
    codigo_categoria varchar(45)
)
BEGIN
insert into produto (
	descricao_produto,
	classe_produto,
	status_produto, 
	preco_compra_produto, 
	compra_imposto_produto, 
	margem_lucro_produto, 
	preco_venda_produto, 
	estoque_disponivel_produto, 
	estoque_min_produto,
	estoque_max_produto,
	estoque_vinculado_produto,
	estoque_previsto_produto, 
	descricoes_detalhadas_produto, 
	observacoes_produto,
    tipo_produto,
    categoria_produto
)
values(
	descricao,
	classe,
	status, 
	preco_compra, 
	compra_imposto, 
	margem_lucro, 
	preco_venda, 
	estoque_disponivel, 
	estoque_min,
	estoque_max,
	estoque_vinculado,
	estoque_previsto, 
	descricoes_detalhadas, 
	observacoes,
    codigo_tipo,
    codigo_categoria
);
END //
DELIMITER;

DELIMITER //
CREATE PROCEDURE pr_delete_produto(
	id int
)
BEGIN
    delete from produto where id_produto = id;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE pr_select_produto(
	id int
)
BEGIN
    select * from produto where id_produto = id;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE pr_select_produtos(
	descricao varchar(45)
)
BEGIN
    if (descricao is null) then
		select * from produto;
	else
        select * from produto where descricao_produto like concat('%', descricao, '%');
	end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE pr_update_produto(
	id int,
	descricao varchar(100), 
	classe varchar(45), 
	status varchar(45), 
	preco_compra decimal(10,0), 
	compra_imposto decimal(10,0), 
	margem_lucro decimal(10,0), 
	preco_venda decimal(10,0),
	estoque_disponivel decimal(10,0),
	estoque_min decimal(10,0),
	estoque_max decimal(10,0),
	estoque_vinculado decimal(10,0),
	estoque_previsto decimal(10,0),
	descricoes_detalhadas varchar(1000),
	observacoes varchar(1000),
    codigo_tipo varchar(45),
    codigo_categoria varchar(45)
)
BEGIN
	update produto set
    
	descricao_produto = descricao,
	classe_produto = classe,
	status_produto = status,
	preco_compra_produto =  preco_compra,
	compra_imposto_produto = compra_imposto,
	margem_lucro_produto = margem_lucro,
	preco_venda_produto = preco_venda,
	estoque_disponivel_produto = estoque_disponivel,
	estoque_min_produto = estoque_min,
	estoque_max_produto = estoque_max,
	estoque_vinculado_produto = estoque_vinculado,
	estoque_previsto_produto = estoque_previsto,
	descricoes_detalhadas_produto = descricoes_detalhadas,
	observacoes_produto = observacoes,
    tipo_produto = codigo_tipo,
    categoria_produto = codigo_categoria
    
    where id_produto = id;
END //
DELIMITER ;
#------------------------------------------------------------------------------------------------------------------------------------------------
#Categoria Produto
DELIMITER //
CREATE PROCEDURE pr_insert_categoria(
	codigo_categoria varchar(45)
)
BEGIN
insert into categoria_produto (
	codigo_categoria_produto
)
values(
	codigo_categoria
);
END //
DELIMITER;

DELIMITER //
CREATE PROCEDURE pr_select_categoria()
BEGIN
    select codigo_categoria_produto from categoria_produto;
END //
DELIMITER ;
#------------------------------------------------------------------------------------------------------------------------------------------------
#Tipo Produto
DELIMITER //
CREATE PROCEDURE pr_insert_tipo(
	codigo_tipo varchar(45),
    codigo_categoria varchar(45)
)
BEGIN
insert into tipo_produto (
	codigo_tipo_produto,
    categoria_produto
)
values(
	codigo_tipo,
	codigo_categoria
);
END //
DELIMITER;

DELIMITER //
CREATE PROCEDURE pr_select_tipo()
BEGIN
    select codigo_tipo_produto from tipo_produto;
END //
DELIMITER ;
#------------------------------------------------------------------------------------------------------------------------------------------------
#Medidas Produto
DELIMITER //
CREATE PROCEDURE pr_insert_medida_produto(
	unidade_medida_compra char(2),
	unidade_medida_estoque char(2),
	qtde_caixa decimal(10,0),
	taxa_conversao decimal(10,0),
	peso_unitario decimal(10,0),
	kilo_caixa decimal(10,0),
	altura decimal(10,0),
	largura decimal(10,0),
	comprimento decimal(10,0),
	volume decimal(10,0),
	id_produto int
)
BEGIN
insert into medida_produto (
	unidade_medida_compra,
	unidade_medida_estoque,
	qtde_caixa,
	taxa_conversao,
	peso_unitario,
	kilo_caixa,
	altura_produto,
	largura_produto,
	comprimento_produto,
	volume_produto,
	produto_id_produto
)
values(
	unidade_medida_compra,
	unidade_medida_estoque,
	qtde_caixa,
	taxa_conversao,
	peso_unitario,
	kilo_caixa,
	altura,
	largura,
	comprimento,
	volume,
	id_produto
);
END //
DELIMITER;

DELIMITER //
CREATE PROCEDURE pr_select_medida_produto(
	id_produto_produto int
)
BEGIN
    select * from medida_produto where produto_id_produto = id_produto_produto;
END //
DELIMITER ;