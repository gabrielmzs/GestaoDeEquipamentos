using System.Collections;
using System.Globalization;

namespace GestaoDeEquipamentos {
   
    internal class Program {
        static ArrayList nomeEquipamento = new ArrayList() { "Nome", "Máquina", "Impressora", "Furadeira", "Sapato", "Lala" };
        static ArrayList precoAquisicao = new ArrayList() { "Preço", 300, 5000, 600, 300, 53 };
        static ArrayList numeroSerie = new ArrayList() { "Número de Série", 1413, 523, 5234, 6436, 2342 };
        static ArrayList dataFabricacao = new ArrayList() { "Data de Fabricação", 23091999, 01052018, 07102015, 24102022, 0101 / 1998 };
        static ArrayList fabricante = new ArrayList() { "Fabricante", "machineTop", "Xerox", "Still", "CouroBom", "Telettubies" };
        static ArrayList chamado = new ArrayList() { "Chamado", "Cagada", "Cagada Gigante", "Deu Merda" };
        static ArrayList descChamado = new ArrayList() { "Descrição", "Deu ruim o negocio aqui", "Entupiram o vaso", "Cagaram na parede" };
        static ArrayList aberturaChamado = new ArrayList() { "Abertura", new DateTime(2023, 03, 29), new DateTime(2023, 03, 30), new DateTime(2023, 03, 27) };
        static ArrayList indiceEquip = new ArrayList() { "Equipamento", "Máquina", "Vaso", "Banheiro" };

        static int MenuInicial() {
            Console.Clear();
            Console.WriteLine("1 - Editar Equipamentos");
            Console.WriteLine("2 - Monitorar Chamados");
            Console.WriteLine("0 - Sair");
            int escolha = int.Parse(Console.ReadLine());
            return escolha;
        }
        static int MenuOpcoes() {
            Console.Clear();
            Console.WriteLine("1 - Registrar");
            Console.WriteLine("2 - Mostrar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Deletar");
            Console.WriteLine("0 - Voltar");
            int escolha2 = int.Parse(Console.ReadLine());
            return escolha2;
        }
        static void RegistrarEquip() {
            Console.Clear();
            Console.WriteLine("Informe o nome do equipamento: ");
            string nome = Console.ReadLine();
            while (nome.Length < 5) {
                Console.WriteLine("O nome deve ter no mínimo 5 caracteres, digite novamente: ");
                nome = Console.ReadLine();
            }
            nomeEquipamento.Add(nome);
            Console.WriteLine("Informe o preço de aquisição: ");
            precoAquisicao.Add(Console.ReadLine());
            Console.WriteLine("Informe o número de série: ");
            numeroSerie.Add(Console.ReadLine());
            Console.WriteLine("Informe a data de fabricação (dd/mm/aaaa): ");
            dataFabricacao.Add(Console.ReadLine());
            Console.WriteLine("Informe o fabricante: ");
            fabricante.Add(Console.ReadLine());

        }
        static void ImprimirEquip() {
            Console.WriteLine($"Indíce".PadRight(10) + $"|{nomeEquipamento[0]}".PadRight(30) + $"|{precoAquisicao[0]}".PadRight(20) + $"|{numeroSerie[0]}".PadRight(20) + $"|{dataFabricacao[0]}".PadRight(20) + $"|{fabricante[0]}".PadRight(20));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            for (int i = 1; i < nomeEquipamento.Count; i++) {
                Console.WriteLine($"{i}".PadRight(10) + $"|{nomeEquipamento[i]}".PadRight(30) + $"|{precoAquisicao[i]}".PadRight(20) + $"|{numeroSerie[i]}".PadRight(20) + $"|{dataFabricacao[i]}".PadRight(20) + $"|{fabricante[i]}".PadRight(20));

            }
            Console.ReadLine();
        }
        static void EditarEquip() {
            ImprimirEquip();
            Console.Write("Digite o número do indice do item a ser editado: ");
            int indice = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do equipamento: ");
            nomeEquipamento[indice] = Console.ReadLine();
            Console.Write("Informe o preço de aquisição: ");
            precoAquisicao[indice] = Console.ReadLine();
            Console.Write("Informe o número de série: ");
            numeroSerie[indice] = Console.ReadLine();
            Console.Write("Informe a data de fabricação (dd/mm/aaaa): ");
            dataFabricacao[indice] = Console.ReadLine();
            Console.Write("Informe o fabricante: ");
            fabricante[indice] = Console.ReadLine();
        }
        static void ExcluirEquip() {
            ImprimirEquip();
            Console.WriteLine("Digite o número do indice do item a ser Excluído: ");
            int indice = int.Parse(Console.ReadLine());
            nomeEquipamento.RemoveAt(indice);
            precoAquisicao.RemoveAt(indice);
            numeroSerie.RemoveAt(indice); ;
            dataFabricacao.RemoveAt(indice); ;
            fabricante.RemoveAt(indice);
        }
        static void RegistrarChamado() {
            Console.WriteLine($"Indíce".PadRight(10) + $"|{nomeEquipamento[0]}".PadRight(30) + $"|{precoAquisicao[0]}".PadRight(20) + $"|{numeroSerie[0]}".PadRight(20) + $"|{dataFabricacao[0]}".PadRight(20) + $"|{fabricante[0]}".PadRight(20));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            for (int i = 1; i < nomeEquipamento.Count; i++) {
                Console.WriteLine($"{i}".PadRight(10) + $"|{nomeEquipamento[i]}".PadRight(30) + $"|{precoAquisicao[i]}".PadRight(20) + $"|{numeroSerie[i]}".PadRight(20) + $"|{dataFabricacao[i]}".PadRight(20) + $"|{fabricante[i]}".PadRight(20));

            }
            Console.WriteLine("Informe o indíce do equipamento do chamado: ");
            int equipamento = int.Parse(Console.ReadLine());
            indiceEquip.Add(nomeEquipamento[equipamento]);
            Console.Clear();
            Console.ReadLine();
            Console.WriteLine("Informe o título do chamado: ");
            chamado.Add(Console.ReadLine());
            Console.WriteLine("Informe a descrição do chamado: ");
            descChamado.Add(Console.ReadLine());
            Console.WriteLine("Informe a data de abertura do chamado: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            aberturaChamado.Add(data);
        }
        static void EscreverChamado() {
            DateTime dataAtual = DateTime.Today;
            Console.WriteLine($"Indíce".PadRight(8) + $"|{chamado[0]}".PadRight(20) + $"|{indiceEquip[0]}".PadRight(15) + $"|{aberturaChamado[0]}".PadRight(15) + $"|Dias Abertos");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            for (int i = 1; i < chamado.Count; i++) {
                TimeSpan diaspassados = dataAtual - (DateTime)aberturaChamado[i];
                var dataFormatada = string.Format("{0:dd/MM/yyyy}", aberturaChamado[i]);
                Console.WriteLine($"{i}".PadRight(8) + $"|{chamado[i]}".PadRight(20) + $"|{indiceEquip[i]}".PadRight(15) + $"|{dataFormatada}".PadRight(15) + $"|{diaspassados.TotalDays}");
            }
            Console.ReadLine();
        }
        static void EditarChamado() {
            EscreverChamado();
            Console.WriteLine("Informe o indíce do chamado a ser Editado:");
            int indice = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o indíce do equipamento do chamado: ");
            int equipamento = int.Parse(Console.ReadLine());
            indiceEquip[indice] = nomeEquipamento[equipamento];
            Console.WriteLine("Informe o título do chamado: ");
            chamado[indice] = Console.ReadLine();
            Console.WriteLine("Informe a descrição do chamado: ");
            descChamado[indice] = Console.ReadLine();
            Console.WriteLine("Informe a data de abertura do chamado: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            aberturaChamado[indice] = data;
        }
        static void ExcluirChamado() {
            EscreverChamado();
            Console.WriteLine("Informe o indíce do chamado a ser Excluído:");
            int indice = int.Parse(Console.ReadLine());

            indiceEquip.RemoveAt(indice);
            chamado.RemoveAt(indice);
            descChamado.RemoveAt(indice);
            aberturaChamado.RemoveAt(indice);
        }
        static void Main(string[] args) {
            
            int escolha = MenuInicial();

            while (escolha != 3) {

                if (escolha == 1) {
                    int escolha2 = MenuOpcoes();

                    if (escolha2 == 1) RegistrarEquip();
                    if (escolha2 == 2) ImprimirEquip();
                    if (escolha2 == 3) EditarEquip();
                    if (escolha2 == 4) ExcluirEquip();
                    if (escolha2 == 0) escolha = MenuInicial();
                }
            
                if(escolha == 2) {
                    int escolha2 = MenuOpcoes();

                    if (escolha2 == 1) RegistrarChamado();
                    if (escolha2 == 2) EscreverChamado();
                    if (escolha2 == 4) ExcluirChamado();
                    if (escolha2 == 3) EditarChamado();
                    if (escolha2 == 0) escolha = MenuInicial();
                }
                if(escolha == 0) break;
            }
        }
    }
}