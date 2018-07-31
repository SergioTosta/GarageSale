using GarageSale.Models;
using System;
using System.Collections.Generic;

namespace GarageSale.DataProviders
{
    public class ProductService
    {
        public static List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product(1
                                , "Espremedor de Fruta"
                                , "Espremedor de Fruta Britânia"
                                , "Acompanha 2 cones para extração: Um para frutas maiores como laranja e outro para frutas menores como limão, além de jarra com peneira que separa as sementes e bagaços do suco"
                                , new List<string>() { "/images/1_2.jpg" 
                                                      ,"/images/1_3.jpg"
                                }
                                , 60.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(2
                                , "Máquina de Pão"
                                , "Máquina de Pão Britânia"
                                , @"Pão macio, quentinho e fresco todos os dias.Muito fácil de preparar: Basta colocar os ingredientes e programar a máquina.Ela se encarrega de bater, descansar a massa e assá - la.
Combinação de até 12 programas diferentes;
            Faz 4 tamanhos de pão 450g, 600g, 900g, 1200g;
            Ajusta a cor do pão como quiser: mais claro, médio ou mais escuro;
            Forma revestida de material antiaderente de fácil remoção, que facilita a limpeza;
            Janela de vidro temperado que possibilita observar o preparo;
            Base antiderrapante;
            Programa a máquina para fazer o pão com até 13 horas de antecedência;
            Após o término do preparo, o pão permanecerá quentinho por 60 minutos;
            Não esquenta a parede externa;"
                                , new List<string>() { "/images/2_1.jpg"
                                                      ,"/images/2_2.jpg"
                                }
                                , 130.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(3
                                , "Aparelho de Jantar I"
                                , "Aparelho de Jantar Biona Azul - 20 peças"
                                , @"Aparelho de Jantar e Chá Oxford Donna Grecia com 20 Peças
4 pratos rasos
4 pratos fundos
4 pratos de sobremesa
4 xícaras de chá
4 pires de chá"

                                , new List<string>() { "/images/3_1.jpg"
                                                      ,"/images/3_3.jpg"
                                                      ,"/images/3_4.jpg"
                                }
                                , 150.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(4
                                , "Jogo Americano "
                                , "Jogo Americano Esteirinha Marrom"
                                , "Jogo Americano Esteirinha Marrom 4 peças"
                                , new List<string>() { "/images/4_1.jpg"}
                                , 25.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(5
                                , "Ventilador"
                                , "Ventilador Arno Turbo Silencio Maxx"
                                , "Potente e silencioso: 3 velocidades com maior fluxo de ar e baixo nível de ruído - Inclinação vertical e oscilação horizontal: ajustes fáceis para direcionar o vento e deixar o ambiente agradável - Grade segura: produzida sob norma internacional de segurança, não permite o contato com a hélice - Fabricado em plástico - Silencioso - Fácil limpeza"
                                , new List<string>() { "/images/5_1.jpg" }
                                , 100.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(7
                                , "Conjunto Marinex"
                                , "Conjunto Marinex"
                                , "Conjunto Marinex 2 peças"
                                , new List<string>() { "/images/7_1.jpg"
                                                     , "/images/7_2.jpg"
                                }
                                , 20.00
                                , "Outubro/18"
                                , false)
                         );

            products.Add(new Product(8
                                , "Porta-Chaves"
                                , "Porta-Chaves"
                                , "Porta-Chaves Guitarra"
                                , new List<string>() { "/images/8_1.jpg"}
                                , 20.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(9
                                , "Guirlanda Natal"
                                , "Guirlanda Natal"
                                , "Guirlanda Natal Boneco de Neve"
                                , new List<string>() { "/images/9_1.jpg"
                                                      ,"/images/9_2.jpg"
                                }
                                , 30.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(10
                                , "Balança Digital"
                                , "Balança Digital"
                                , "Balança Digital"
                                , new List<string>() { "/images/10_1.jpg" }
                                , 25.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(11
                                , "Aparelho de Jantar II"
                                , "Aparelho de Jantar Oxford"
                                , @"Aparelho de Jantar e Chá Mail Order Quartier White com 20 Peças
3 Pratos rasos
4 Pratos fundos - (1 com pequena rachadura, porém, utilizável)
4 Pratos sobremesa
4 Xícaras de chá
4 Pires de chá"
                                , new List<string>() { "/images/11_1.jpg"
                                                      ,"/images/11_2.jpg"
                                                      ,"/images/11_3.jpg"
                                                      ,"/images/11_4.jpg"
                                }
                                , 140.00
                                , "Outubro/18"
                                , false)
                         );

            products.Add(new Product(12
                                , "Fruteira"
                                , "Fruteira"
                                , "Fruteira em Vidro"
                                , new List<string>() { "/images/12_1.jpg" }
                                , 20.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(13
                                , "Conjunto de Potes de Vidro"
                                , "Conjunto de Potes de Vidro 8 peças"
                                , @"Conjunto de Potes de Vidro 8 peças
3 grandes, 1 médio e 4 pequenos"
                                , new List<string>() { "/images/13_1.jpg"
                                                      ,"/images/13_2.jpg"
                                }
                                , 40.00
                                , "Outubro/18"
                                , false)
             );

            products.Add(new Product(14
                                , "Escada"
                                , "Escada 3 Degraus"
                                , "Escada em alumínio com 3 degraus, leve e prática"
                                , new List<string>() { "/images/14_1.jpg"
                                                      ,"/images/14_2.jpg"
                                }
                                , 35.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(15
                                , "Puff"
                                , "2 Puffs Vermelhos"
                                , "2 Puffs Vermelhos"
                                , new List<string>() { "/images/15_1.jpg" }
                                , 20.00
                                , "Outubro/18"
                                , false)
                         );

            products.Add(new Product(16
                                , "Afiador de Facas"
                                , "Afiador de Facas Tramontina"
                                , "Afiador de Facas Tramontina"
                                , new List<string>() { "/images/16_1.jpg"
                                                      ,"/images/16_2.jpg"
                                }
                                , 50.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(17
                                , "Taça de Espumante I"
                                , "2 Taças de Espumante"
                                , "2 Taças de Espumante"
                                , new List<string>() { "/images/17_1.jpg"
                                                      ,"/images/17_2.jpg"
                                }
                                , 15.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(18
                                , "Taça de Espumante II"
                                , "2 Taças de Espumante"
                                , "2 Taças de Espumante"
                                , new List<string>() { "/images/18_1.jpg"}
                                , 15.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(19
                                , "Taça de Milkshake"
                                , "2 Taças de Milkshake"
                                , "2 Taças de Milkshake"
                                , new List<string>() { "/images/19_1.jpg" }
                                , 30.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(20
                                , "Kit Confeitar"
                                , "Saco de Confeiteiro em Silicone Vermelho"
                                , "Acompanha 6 bicos que permitem decorar bolos e Cupcakes à sua maneira, e criar diversos tipos de cobertura. Este prático saco de confeiteiro é feito de silicone e plástico."
                                , new List<string>() { "/images/20_1.jpg"
                                                      ,"/images/20_2.jpg"
                                                      ,"/images/20_3.jpg"
                                }
                                , 20.00
                                , "Disponível"
                                , false)
                         );

            products.Add(new Product(21
                    , "Caneca de Chopp"
                    , "Caneca de Chopp"
                    , "Grande (600ml) e Pequena (355ml)"
                    , new List<string>() { "/images/21_1.jpg" }
                    , 40.00
                    , "Disponível"
                    , false)
             );

            products.Add(new Product(22
                    , "Utensílios para Cozinha"
                    , "5 peças"
                    , @"Conjunto em Inox
Acompanha 1 Escumadeira, 1 Concha, 1 Colher para Arroz, 1 Espátula para Frituras, 1 Pegador para Massas"
                    , new List<string>() { "/images/22_1.jpg" }
                    , 20.00
                    , "Outubro/18"
                    , false)
             );

            return products;
        }
    }
}
