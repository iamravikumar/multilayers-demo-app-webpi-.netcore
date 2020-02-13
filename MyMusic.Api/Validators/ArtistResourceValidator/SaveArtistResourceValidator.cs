using FluentValidation;
using MyMusic.Api.Resources.ArtistResources;

namespace MyMusic.Api.Validators.ArtistResourceValidator
{
    public class SaveArtistResourceValidator : AbstractValidator<SaveArtistResource>
    {
        public SaveArtistResourceValidator()
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}
