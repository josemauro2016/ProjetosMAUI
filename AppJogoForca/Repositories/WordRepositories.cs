using AppJogoForca.Models;

namespace AppJogoForca.Repositories;

public class WordRepositories
{
    private List<Word> _words;

    public WordRepositories()
    {
        _words = new List<Word>();
        _words.Add(new Word("Nome", "Maria".ToUpper()));
        _words.Add(new Word("Vegetal", "Cenoura".ToUpper()));
        _words.Add(new Word("Fruta", "Abacate".ToUpper()));
        _words.Add(new Word("Tempero", "Alho".ToUpper()));
        _words.Add(new Word("Carro", "Fusca".ToUpper()));
        _words.Add(new Word("Esporte", "Ciclismo".ToUpper()));

        // Nomes Próprios
        _words.Add(new Word("Nome", "Ana".ToUpper()));
        _words.Add(new Word("Nome", "Bruno".ToUpper()));
        _words.Add(new Word("Nome", "Carla".ToUpper()));
        _words.Add(new Word("Nome", "Daniel".ToUpper()));
        _words.Add(new Word("Nome", "Eduarda".ToUpper()));
        _words.Add(new Word("Nome", "Fabio".ToUpper()));
        _words.Add(new Word("Nome", "Gabriel".ToUpper()));
        _words.Add(new Word("Nome", "Helena".ToUpper()));
        _words.Add(new Word("Nome", "Igor".ToUpper()));
        _words.Add(new Word("Nome", "Julia".ToUpper()));

        // Vegetais e Legumes
        _words.Add(new Word("Vegetal", "Abóbora".ToUpper()));
        _words.Add(new Word("Vegetal", "Berinjela".ToUpper()));
        _words.Add(new Word("Vegetal", "Brócolis".ToUpper()));
        _words.Add(new Word("Vegetal", "Chuchu".ToUpper()));
        _words.Add(new Word("Vegetal", "Espinafre".ToUpper()));
        _words.Add(new Word("Vegetal", "Pepino".ToUpper()));
        _words.Add(new Word("Vegetal", "Quiabo".ToUpper()));
        _words.Add(new Word("Vegetal", "Rabanete".ToUpper()));
        _words.Add(new Word("Vegetal", "Tomate".ToUpper()));
        _words.Add(new Word("Vegetal", "Vagem".ToUpper()));

        // Frutas
        _words.Add(new Word("Fruta", "Banana".ToUpper()));
        _words.Add(new Word("Fruta", "Caju".ToUpper()));
        _words.Add(new Word("Fruta", "Damasco".ToUpper()));
        _words.Add(new Word("Fruta", "Goiaba".ToUpper()));
        _words.Add(new Word("Fruta", "Jabuticaba".ToUpper()));
        _words.Add(new Word("Fruta", "Kiwi".ToUpper()));
        _words.Add(new Word("Fruta", "Laranja".ToUpper()));
        _words.Add(new Word("Fruta", "Manga".ToUpper()));
        _words.Add(new Word("Fruta", "Morango".ToUpper()));
        _words.Add(new Word("Fruta", "Pêssego".ToUpper()));

        // Temperos
        _words.Add(new Word("Tempero", "Açafrão".ToUpper()));
        _words.Add(new Word("Tempero", "Canela".ToUpper()));
        _words.Add(new Word("Tempero", "Coentro".ToUpper()));
        _words.Add(new Word("Tempero", "Cominho".ToUpper()));
        _words.Add(new Word("Tempero", "Cravo".ToUpper()));
        _words.Add(new Word("Tempero", "Louro".ToUpper()));
        _words.Add(new Word("Tempero", "Manjericão".ToUpper()));
        _words.Add(new Word("Tempero", "Noz-Moscada".ToUpper()));
        _words.Add(new Word("Tempero", "Orégano".ToUpper()));
        _words.Add(new Word("Tempero", "Pimenta".ToUpper()));

        // Carros
        _words.Add(new Word("Carro", "Corolla".ToUpper()));
        _words.Add(new Word("Carro", "Civic".ToUpper()));
        _words.Add(new Word("Carro", "Gol".ToUpper()));
        _words.Add(new Word("Carro", "Mustang".ToUpper()));
        _words.Add(new Word("Carro", "Ferrari".ToUpper()));
        _words.Add(new Word("Carro", "Palio".ToUpper()));
        _words.Add(new Word("Carro", "Camaro".ToUpper()));
        _words.Add(new Word("Carro", "Uno".ToUpper()));
        _words.Add(new Word("Carro", "Onix".ToUpper()));
        _words.Add(new Word("Carro", "Saveiro".ToUpper()));

        // Esportes
        _words.Add(new Word("Esporte", "Futebol".ToUpper()));
        _words.Add(new Word("Esporte", "Vôlei".ToUpper()));
        _words.Add(new Word("Esporte", "Basquete".ToUpper()));
        _words.Add(new Word("Esporte", "Natação".ToUpper()));
        _words.Add(new Word("Esporte", "Tênis".ToUpper()));
        _words.Add(new Word("Esporte", "Judô".ToUpper()));
        _words.Add(new Word("Esporte", "Boxe".ToUpper()));
        _words.Add(new Word("Esporte", "Surfe".ToUpper()));
        _words.Add(new Word("Esporte", "Atletismo".ToUpper()));
        _words.Add(new Word("Esporte", "Karatê".ToUpper()));

        // Animais
        _words.Add(new Word("Animal", "Cachorro".ToUpper()));
        _words.Add(new Word("Animal", "Gato".ToUpper()));
        _words.Add(new Word("Animal", "Elefante".ToUpper()));
        _words.Add(new Word("Animal", "Girafa".ToUpper()));
        _words.Add(new Word("Animal", "Leão".ToUpper()));
        _words.Add(new Word("Animal", "Tigre".ToUpper()));
        _words.Add(new Word("Animal", "Zebra".ToUpper()));
        _words.Add(new Word("Animal", "Cavalo".ToUpper()));
        _words.Add(new Word("Animal", "Pinguim".ToUpper()));
        _words.Add(new Word("Animal", "Tartaruga".ToUpper()));

        // Países
        _words.Add(new Word("País", "Brasil".ToUpper()));
        _words.Add(new Word("País", "Argentina".ToUpper()));
        _words.Add(new Word("País", "Canadá".ToUpper()));
        _words.Add(new Word("País", "França".ToUpper()));
        _words.Add(new Word("País", "Japão".ToUpper()));
        _words.Add(new Word("País", "México".ToUpper()));
        _words.Add(new Word("País", "Portugal".ToUpper()));
        _words.Add(new Word("País", "Alemanha".ToUpper()));
        _words.Add(new Word("País", "Itália".ToUpper()));
        _words.Add(new Word("País", "Egito".ToUpper()));

        // Objetos
        _words.Add(new Word("Objeto", "Cadeira".ToUpper()));
        _words.Add(new Word("Objeto", "Mesa".ToUpper()));
        _words.Add(new Word("Objeto", "Celular".ToUpper()));
        _words.Add(new Word("Objeto", "Relógio".ToUpper()));
        _words.Add(new Word("Objeto", "Caneta".ToUpper()));
        _words.Add(new Word("Objeto", "Caderno".ToUpper()));
        _words.Add(new Word("Objeto", "Luminária".ToUpper()));
        _words.Add(new Word("Objeto", "Tesoura".ToUpper()));
        _words.Add(new Word("Objeto", "Garrafa".ToUpper()));
        _words.Add(new Word("Objeto", "Óculos".ToUpper()));

        // Profissões
        _words.Add(new Word("Profissão", "Médico".ToUpper()));
        _words.Add(new Word("Profissão", "Professor".ToUpper()));
        _words.Add(new Word("Profissão", "Engenheiro".ToUpper()));
        _words.Add(new Word("Profissão", "Advogado".ToUpper()));
        _words.Add(new Word("Profissão", "Cozinheiro".ToUpper()));
        _words.Add(new Word("Profissão", "Pintor".ToUpper()));
        _words.Add(new Word("Profissão", "Piloto".ToUpper()));
        _words.Add(new Word("Profissão", "Bombeiro".ToUpper()));
        _words.Add(new Word("Profissão", "Policial".ToUpper()));
        _words.Add(new Word("Profissão", "Escritor".ToUpper()));
    }

    public Word GetRandomWord()
    {
        Random rand = new Random();
        var number = rand.Next(0, _words.Count);
        return _words[number];
    }
}
