using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_menos_Distante.Entities
{
    internal class Equipamento
    {
        //Propriedades
        public string nome { get; set; }
        public int contagem { get; set; }
        


        //Construtores
        public Equipamento() { }
        
        public Equipamento(string nome, int contagem)
        {
            this.nome = nome;
            this.contagem = contagem;
        }

        

        //Secção de métodos
        public void DeprecateEquipment()  //Este método serve para retirar algum equipamento à lista, ou seja, por exemplo, se tem 5 balanças este equipamento faz com que desça para 4
        {
            this.contagem--;
        }

        public void IncrementEquipment() //Este método serve para adicionar algum equipamento à lista, ou seja, por exemplo, se tem 5 balanças este equipamento faz com que aumente para 6
        {
            this.contagem++;
        }

        public static void GerirEquipamento()
        {
            //Aqui instanciamos uma lista de equipamentos com a quantidade dos mesmos
            List<Equipamento> equipamentos = new List<Equipamento>();

            equipamentos.Add(new Equipamento("Desfibrilador", 10));
            equipamentos.Add(new Equipamento("Viaturas ligeiras", 5));
            equipamentos.Add(new Equipamento("Viaturas de rastreio ambulante", 4));
            equipamentos.Add(new Equipamento("Estetoscopios", 10));
            equipamentos.Add(new Equipamento("Eletrocardiograma (ECG)", 13));
            equipamentos.Add(new Equipamento("Balança", 6));
            equipamentos.Add(new Equipamento("Fita métrica", 9));
            equipamentos.Add(new Equipamento("Medidor de glicose", 7));
            equipamentos.Add(new Equipamento("Medidor de colesterol", 9));
            equipamentos.Add(new Equipamento("Teste de esforço ou ergoespirometria", 15));
            equipamentos.Add(new Equipamento("Balança de bioimpedância", 3));
            equipamentos.Add(new Equipamento("Monitor de frequência cardíaca", 1));
            equipamentos.Add(new Equipamento("Oxímetro de pulso", 8));

            Console.WriteLine();
            Console.WriteLine("Lista de equipamentos: ");
            Console.WriteLine();

            foreach (Equipamento equipamento in equipamentos)
            {
                Console.WriteLine("Nome: " + equipamento.nome + ": " + equipamento.contagem); //Faz a contagem (soma ou subtração) do equipamento selecionado
            }


            //Aqui perguntamos se quer acrescentar ou retirar à quantidade de equipamentos e dependendo da resposta ele executa os um dos metodos anteriores
            Console.WriteLine();
            Console.WriteLine("Deseja retirar ou acrescentar algum equipamento?");
            string opcao = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Qual? ");
            string equip = Console.ReadLine();
            Console.WriteLine();

            int[] x = new int[13];

            //Condição que permite selecionar o equipamento pretendido e remover uma unidade
            if (opcao == "retirar")
            {
                if (equip == "Desfibrilador")
                {
                    equipamentos[0].DeprecateEquipment();
                }
                else if (equip == "Viaturas ligeiras")
                {
                    equipamentos[1].DeprecateEquipment();
                }
                else if (equip == "Viaturas de rastreio ambulante")
                {
                    equipamentos[2].DeprecateEquipment();
                }
                else if (equip == "Estetoscopios")
                {
                    equipamentos[3].DeprecateEquipment();
                }
                else if (equip == "Eletrocardiograma (ECG")
                {
                    equipamentos[4].DeprecateEquipment();
                }
                else if (equip == "Balança")
                {
                    equipamentos[5].DeprecateEquipment();
                }
                else if (equip == "Fita métrica")
                {
                    equipamentos[6].DeprecateEquipment();
                }
                else if (equip == "Medidor de glicose")
                {
                    equipamentos[7].DeprecateEquipment();
                }
                else if (equip == "Medidor de colesterol")
                {
                    equipamentos[8].DeprecateEquipment();
                }
                else if (equip == "Teste de esforço ou ergoespirometria")
                {
                    equipamentos[9].DeprecateEquipment();
                }
                else if (equip == "Balança de bioimpedância")
                {
                    equipamentos[10].DeprecateEquipment();
                }
                else if (equip == "Monitor de frequência cardíaca")
                {
                    equipamentos[11].DeprecateEquipment();
                }
                else if (equip == "Oxímetro de pulso")
                {
                    equipamentos[12].DeprecateEquipment();
                }
            }
            //Condição que permite selecionar o equipamento pretendido e adicionar uma unidade
            else if (opcao == "acrescentar")
            {
                if (equip == "Desfibrilador")
                {
                    equipamentos[0].IncrementEquipment();
                }
                else if (equip == "Viaturas ligeiras")
                {
                    equipamentos[1].IncrementEquipment();
                }
                else if (equip == "Viaturas de rastreio ambulante")
                {
                    equipamentos[2].IncrementEquipment();
                }
                else if (equip == "Estetoscopios")
                {
                    equipamentos[3].IncrementEquipment();
                }
                else if (equip == "Eletrocardiograma (ECG")
                {
                    equipamentos[4].IncrementEquipment();
                }
                else if (equip == "Balança")
                {
                    equipamentos[5].IncrementEquipment();
                }
                else if (equip == "Fita métrica")
                {
                    equipamentos[6].IncrementEquipment();
                }
                else if (equip == "Medidor de glicose")
                {
                    equipamentos[7].IncrementEquipment();
                }
                else if (equip == "Medidor de colesterol")
                {
                    equipamentos[8].IncrementEquipment();
                }
                else if (equip == "Teste de esforço ou ergoespirometria")
                {
                    equipamentos[9].IncrementEquipment();
                }
                else if (equip == "Balança de bioimpedância")
                {
                    equipamentos[10].IncrementEquipment();
                }
                else if (equip == "Monitor de frequência cardíaca")
                {
                    equipamentos[11].IncrementEquipment();
                }
                else if (equip == "Oxímetro de pulso")
                {
                    equipamentos[12].IncrementEquipment();
                }
            }

            //Atualização da lista de equipamentos
            Console.WriteLine();
            Console.WriteLine("Lista atualizada: ");
            Console.WriteLine();
            foreach (Equipamento equipamento in equipamentos)
            {
                Console.WriteLine("Nome: " + equipamento.nome + ": " + equipamento.contagem);
            }
        }
    }
}
