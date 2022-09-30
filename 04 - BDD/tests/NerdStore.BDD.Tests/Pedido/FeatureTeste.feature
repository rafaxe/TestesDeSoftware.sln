Funcionalidade: FeatureTeste
	Como um usuário
	Eu desejo colocar um item no carrinho
	Para que eu possa comprá-lo posteriormente

@tag1
Cenário: Adicionar item com sucesso a um novo pedido
	Dado O usuario esteja logado
	Quando O usuario adicionar uma unidade ao carrinho
	Então O usuario será redirecionado ao resumo da compra

