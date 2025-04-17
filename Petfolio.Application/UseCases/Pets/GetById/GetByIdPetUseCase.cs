using Microsoft.VisualBasic;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetByIdPetUseCase
{
    public ResponsePetJson Execute(int id)
    {
        var pet = new ResponsePetJson
        {
            Id = id,
            Name = "Fido",
            Birthday = new DateTime(year: 2022, month: 1, day: 1),
            Type = Communication.Enum.PetType.Cat
        };
        
        return pet;
    }

}