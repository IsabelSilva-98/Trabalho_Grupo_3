using Saude_menos_Distante.Entities;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Collections.Concurrent;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System;

namespace Saude_menos_Distante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                // Primeiro passo do programa - pedir username e password para poder aceder aos diferentes menus
                Console.WriteLine();
                Console.WriteLine("Login: ");
                string userName = Console.ReadLine();
                Console.WriteLine("Senha: ");
                string password = Console.ReadLine();

                // Foram instanciados 4 login diferente que representam os 4 colaboradores dentro de uma equipa
                Login login = new Login(userName, password);
                Login login1 = new Login("Admin_03", "6789");
                Login login2 = new Login("Enfermeira_023", "4321");
                Login login3 = new Login("Doutor_001", "1234");
                Login login4 = new Login("Motorista_012", "9876");


                Pessoas pessoaa = new Pessoas();

                // Aqui foi instanciado um utente como exemplo para registar o utente, a consulta e a triagem
                Utente utente = new Utente(11);
                Utente utente1 = new Utente(11, "Maria Ferreira", "1998/05/21", "Feminino", "maria@gmail.com", 912549323, 121451536);
                Consulta consulta2 = new Consulta(1509, "2023/06/12", "HTA Grau II", "Diabetes", "Insulina", "Análises de Sangue");
                Triagem triagem = new Triagem(65, 1.70, 244, 126, 165, 106, "HTA Grau II");


                // Aqui foram instanciados alguns utentes com o intuito de aparecerem no relatório de consultas
                Utente utente2 = new Utente(15, "Joana Silva", "25/10/1995", "Feminino", "joanasilva@gmail.com", 912576333, 465363354);
                Utente utente3 = new Utente(155, "Ana Cunha", "06/02/1990", "Feminino", "anacunha@gmail.com", 916318757, 556484864);
                Utente utente4 = new Utente(1516, "Rita Pinheiro", "13/06/2000", "Feminino", "ritapinheiro@gmail.com", 932486915, 584867464);
                Utente utente5 = new Utente(66, "João Oliveira", "20/09/1990", "Masculino", "joaooliveira@gmail.com", 914759636, 194886465);
                Utente utente6 = new Utente(95, "Duarte Dias", "16/08/1988", "Masculino", "duartedias@gmail.com", 932645515, 278445465);
                Utente utente7 = new Utente(12, "Nuno Carvalho", "08/03/1991", "Masculino", "nunocarvalho@gmail.com", 936151484, 586453464);

                // Aqui foram instanciadas as triagens pertencentes aos utentes acima
                Triagem triagem2 = new Triagem(70, 1.75, 250, 130, 190, 115, "HTA Grau III");
                Triagem triagem3 = new Triagem(95, 1.80, 255, 136, 160, 80, "Hipertensão Sistólica Isolada");
                Triagem triagem4 = new Triagem(55, 1.50, 270, 129, 142, 99, "HTA Grau I");
                Triagem triagem5 = new Triagem(63, 1.72, 240, 133, 161, 102, "HTA Grau II");
                Triagem triagem6 = new Triagem(85, 1.90, 245, 139, 200, 120, "HTA Grau III");
                Triagem triagem7 = new Triagem(80, 1.75, 240, 133, 172, 108, "HTA Grau II");


                //Aqui foram instanciadas as informações de 4 colaboradores exemplo, uma equipa
                Medico medico = new Medico(032, "José Silva", "13/06/1985", "Masculino", "josesilva@gmail.com", 913489357, 001, 150, 20);
                Enfermeira enfermeira = new Enfermeira(105, "Maria Fernandes", "25/10/1995", "Feminino", "mariafernandes@gmail.com", 911555888, 023, 140, 15);
                Administrativo administrativo = new Administrativo(230,"António Mendes", "06/12/1990", "Masculino", "antoniomendes@gmail.com", 933666999, 03, 155, 17);
                Motorista motorista = new Motorista(156, "Manuel Faria", "16/08/1989", "Masculino", "manuelfaria@gmail.com", 912333444, 012, 100, 10);


                if (userName == login1.UserName && password == login1.Password)  // menu do Administrativo
                {
                    int resp = 0;

                    while (resp < 5)
                    {
                        // Estas são as diferentes opções que o menu do administrativo proporciona
                        Console.WriteLine();
                        Console.WriteLine("1 - Registar Utente");
                        Console.WriteLine("2 - Criar Calendário");
                        Console.WriteLine("3 - Gerar Relatórios");
                        Console.WriteLine("4 - Gestão de Equipamento");
                        Console.WriteLine("5 - Sair");
                        resp = int.Parse(Console.ReadLine());

                        if (resp == 1)
                        {
                            //Aqui instanciamos o registo do utente que está como método na classe Utente
                            Utente.RegistoUtente(utente);    
                        }
                        else if (resp == 2)
                        {   //Nesta opção criamos o calendario de marcação de consultas.
                            //Neste caso mostra o administrativo a marcar uma consulta
                            Calendario agenda = new Calendario(2023);  

                            Console.WriteLine();
                            Console.WriteLine("Calendário de Consultas: ");
                            Console.WriteLine();
                            Console.WriteLine("Escolha uma data: ");
                            string data = Console.ReadLine();
                            Console.WriteLine("Hora da consulta: ");
                            string hora = Console.ReadLine();

                            Console.WriteLine();
                            Console.WriteLine("Agendada consulta para dia " + data + " às " + hora);
                            Console.WriteLine();
                            Console.WriteLine("Enviado email para utente Manuel Siva, número de utente 157423684");
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine("Calendário atualizado ");
                            Console.WriteLine("Escolha o mês: ");
                            string mes = Console.ReadLine();

                            Calendario.PrintCalendar(int.Parse(mes), 2023);  //Faz a impressao do calendario de consultas, por mês (com o dia e as horas)

                        }
                        else if (resp == 3)    
                        {
                            // Este é o menu de Relatórios
                            Console.WriteLine();
                            Console.WriteLine("Gerar relatório: ");
                            Console.WriteLine("1 - Relatório de Colaboradores");
                            Console.WriteLine("2 - Relatório de Consultas: ");
                            Console.WriteLine("3 - Relatório de Dados Estatísticos");
                            int relatorio = int.Parse(Console.ReadLine());

                            if (relatorio == 1)
                            {
                                //Aqui mostra um exemplo do que o Administrativo pode inserir para ir buscar a informação dos colaboradores para o relatório.
                                //Neste caso pede os id dos colaboradores que poderão ir automaticamente buscar as informações associadas a essa equipa
                                Console.WriteLine();
                                Console.WriteLine("Gerar Relatorio de Colaboradores ");
                                Console.WriteLine();

                                Console.WriteLine("Insira o ID do Médico: ");
                                string idMedico = Console.ReadLine();

                                Console.WriteLine("Insira o ID da Enfermeira: ");
                                string idEnfermeira = Console.ReadLine();

                                Console.WriteLine("Insira o ID do Administrativo: ");
                                string idAdmin = Console.ReadLine();

                                Console.WriteLine("Insira o ID do Motorista: ");
                                string idMotorista = Console.ReadLine();

                                //Instaciação do relatório de colaboradores, imprime as informações de cada colaborador da equipa
                                RelatorioColaboradores.RelatColab(medico, enfermeira, administrativo, motorista);

                            }
                            else if (relatorio == 2)
                            {
                                //Aqui mostra o admin a inserir o id de uma consulta para poder juntar ao relatório de consultas
                                Console.WriteLine();
                                Console.WriteLine("Relatório de Consultas");
                                Console.WriteLine();

                                Console.WriteLine("Data: ");
                                DateTime data = DateTime.Now;
                                Console.WriteLine(DateTime.Now);
                                Console.WriteLine("Id da consulta: ");
                                int idConsulta = int.Parse(Console.ReadLine());

                                    if (idConsulta == 1509)
                                    {
                                        Console.WriteLine("Nome: " + utente1.Nome);
                                        Console.WriteLine("Número de utente: " + utente1.NoUtente); // Aqui está instanciada uma consulta exemplo
                                        Console.WriteLine("Diagnóstico: " + triagem.Diagnostico);
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Id de Consulta não encontrado"); // Isto serve para mostrar que somente está associada uma consulta e que não pode mostrar mais nada
                                    }

                                //Instaciação do relatorio de consultas, imprime as informações de cada utente consultado à data de 30/05/2023 (mais uma vez serve como exemplo e não tem mais nenhuma data associada)
                                RelatorioConsultas.RelatConsultas(utente1, triagem, utente2, utente3, utente4, utente5, utente6, utente7, triagem2, triagem3, triagem4, triagem5, triagem6, triagem7);


                            }
                            else if (relatorio == 3)
                            {
                                Console.WriteLine("Gerar relatório de estatísticas do mês: "); // Um exemplo de como pode gerar o relatório
                                int mes = int.Parse(Console.ReadLine());
                                
                                //Este relatorio faz a contagem total das consultas; total das consultas da última semana e do último dia
                                RelatorioEstatisticas.RelatEstatisticas();  
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Relatorio não existe"); //Em caso de clicar num outro botão surge mensagem de aviso
                            }
                        }
                        else if (resp == 4)
                        {
                            // Esta instanciação da gestao de equipamento faz a contagem e permite adicionar ou remover quipamentos.
                            Equipamento.GerirEquipamento();

                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Logout concluído");  // Sempre que o utilizador clica no botão sair surge a mensagem de Logout e volta para a secção de login
                }
                else if (userName == login2.UserName && password == login2.Password) // Login de enfermeiro/a
                {
                    int resp = 0;

                    while (resp < 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("1 - Registar Triagem");
                        Console.WriteLine("2 - Calendário");
                        Console.WriteLine("3 - Relatórios");
                        Console.WriteLine("4 - Sair");
                        resp = int.Parse(Console.ReadLine());

                        if (resp == 1)
                        {   //Mostra os dados do utente(exemplo instanciado) + faz registo da triagem + Imprime os dados e dá o diagnóstico
                            Triagem.RegistoTriagem(utente1);
                        }
                        else if (resp == 2)
                        {
                            //Aqui pede para para escolher o calendário de um mês especifico de forma a aparecer os dias corretos
                            Console.WriteLine();
                            Console.WriteLine("Calendário: ");
                            Console.WriteLine("Escolha o mês: ");
                            string mes = Console.ReadLine();

                            //Faz a impressao do calendario de consultas, por mês (com o dia e as horas)
                            Calendario.PrintCalendar(int.Parse(mes), 2023); 

                        }
                        else if (resp == 3)
                        {
                            // Menu de Relatórios
                            Console.WriteLine();
                            Console.WriteLine("Relatórios");
                            Console.WriteLine("1 - Relatório de Colaboradores");
                            Console.WriteLine("2 - Relatório de Consultas");
                            Console.WriteLine("3 - Relatório de Estatísticas");
                            int relatorio = int.Parse(Console.ReadLine());

                            if (relatorio == 1)
                            {
                                //Instaciação do relatório de colaboradores, imprime as informações de cada colaborador da equipa
                                RelatorioColaboradores.RelatColab(medico, enfermeira, administrativo, motorista);

                            }
                            else if (relatorio == 2)
                            {
                                //Instaciação do relatorio de consultas, imprime as informações de cada utente consultado à data de 30/05/2023 (mais uma vez serve como exemplo e não tem mais nenhuma data associada)
                                RelatorioConsultas.RelatConsultas(utente1, triagem, utente2, utente3, utente4, utente5, utente6, utente7, triagem2, triagem3, triagem4, triagem5, triagem6, triagem7);

                            }
                            else if (relatorio == 3)
                            {
                                //Este relatório faz a contagem total das consultas; total das consultas da última semana e do último dia
                                RelatorioEstatisticas.RelatEstatisticas();
                            }
                            else
                            {
                                Console.WriteLine("Relatório não existe"); //Em caso de clicar num outro botão surge mensagem de aviso
                            }
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Logout concluido");  // Sempre que o utilizador clica no botão sair surge a mensagem de Logout e volta para a secção de login
                }
                else if (userName == login3.UserName && password == login3.Password) // Login do Medico
                {
                    int resp = 0;

                    while (resp < 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("1 - Registar Consulta");
                        Console.WriteLine("2 - Calendário");
                        Console.WriteLine("3 - Relatórios");
                        Console.WriteLine("4 - Sair");
                        resp = int.Parse(Console.ReadLine());

                        if (resp == 1)
                        {
                            // Mostra o histórico do utente (registo e triagem) + faz registo da consulta + Imprime resumo da consulta
                            Consulta.RegistarConsulta(pessoaa, utente1, consulta2, triagem, consulta2);

                        }
                        else if (resp == 2)
                        {
                            //Faz a impressao do calendario de consultas, por mês (com o dia e as horas)
                            Console.WriteLine();
                            Console.WriteLine("Calendário: ");
                            Console.WriteLine("Escolha o mês: ");
                            string mes = Console.ReadLine();

                            Calendario.PrintCalendar(int.Parse(mes), 2023);
                        }
                        else if (resp == 3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Relatórios");
                            Console.WriteLine("1 - Relatório de Colaboradores");
                            Console.WriteLine("2 - Relatório de Consultas");
                            Console.WriteLine("3 - Relatório de Estatísticas");
                            int relatorio = int.Parse(Console.ReadLine());

                            if (relatorio == 1)
                            {
                                //Instaciação do relatório de colaboradores, imprime as informações de cada colaborador da equipa
                                RelatorioColaboradores.RelatColab(medico, enfermeira, administrativo, motorista);
                            }
                            else if (relatorio == 2)
                            {
                                //Instaciação do relatorio de consultas, imprime as informações de cada utente consultado à data de 30/05/2023 (mais uma vez serve como exemplo e não tem mais nenhuma data associada)
                                RelatorioConsultas.RelatConsultas(utente1, triagem, utente2, utente3, utente4, utente5, utente6, utente7, triagem2, triagem3, triagem4, triagem5, triagem6, triagem7);
                            }
                            else if (relatorio == 3)
                            {
                                //Este relatório faz a contagem total das consultas; total das consultas da última semana e do último dia
                                RelatorioEstatisticas.RelatEstatisticas();
                            }
                            else
                            {
                                Console.WriteLine("Relatório não existe"); //Em caso de clicar num outro botão surge mensagem de aviso
                            }

                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Logout concluido");  // Sempre que o utilizador clica no botão sair surge a mensagem de Logout e volta para a secção de login
                }
                else if (userName == login4.UserName && password == login4.Password) //Login de motorista
                {
                    int resp = 0;

                    while (resp < 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("1 - Calendário");
                        Console.WriteLine("2 - Despesas");
                        Console.WriteLine("3 - Sair");
                        resp = int.Parse(Console.ReadLine());

                        if (resp == 1)
                        {
                            //Faz a impressao do calendario de consultas, por mês (com o dia e as horas)
                            Console.WriteLine();
                            Console.WriteLine("Calendário: ");
                            Console.WriteLine("Escolha o mês: ");
                            string mes = Console.ReadLine();

                            Calendario.PrintCalendar(int.Parse(mes), 2023);
                        }
                        else if (resp == 2)
                        {
                            // Este é uma secção para o motorista poder inserir as informações das despesas do veículo
                            Despesa.RegistoDespesas();

                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Logout concluido");   // Sempre que o utilizador clica no botão sair surge a mensagem de Logout e volta para a secção de login
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Login incorreto!"); // Caso houver algum engano ao escrever o username ou password surge a menagem de aviso
                    Console.WriteLine();
                }

            }
            
        }
    }
}