using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_dotnet.Services.CharacterService
{
  public class CharacterService : ICharacterInterface
  {
    private static List<Character> characters = new List<Character> {
        new Character(),
        new Character() { Id = 1, Name = "Tolu", Hitpoint = 300, Class = RpgClass.Cleric }
    };


    public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
    {
        var serviceResponse = new ServiceResponse<List<Character>>();
        characters.Add(newCharacter);
        serviceResponse.Data = characters;
        return serviceResponse;
    }

    public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
    {
        var serviceResponse = new ServiceResponse<List<Character>>();
        serviceResponse.Data = characters;
        return serviceResponse;
    }

    public async Task<ServiceResponse<Character>> GetCharacterById(int id)
    {
        var serviceResponse = new ServiceResponse<Character>();
        var character = characters.FirstOrDefault(c=> c.Id == id);
        serviceResponse.Data = character;
        return serviceResponse;
    }
  }
}