using ErrorOr;

namespace BuberBreakfast.ServiceErrors;

public static class Errors
{
    public static class Breakfast 
    {
        public static Error NotFound => Error.NotFound(
            code: "Breakfast.NotFound",
            description: "Breakfast not found"
        );

         
        public static Error InvalidNameLength => Error.NotFound(
            code: "Breakfast.InvalidNameLength",
            description: $"Breakfast name length is invalid(Must be at least {Models.Breakfast.MaxNameLength} and at most {Models.Breakfast.MaxNameLength} characters long)"
        );

        public static Error InvalidDescriptionLength => Error.NotFound(
            code: "Breakfast.InvalidDescriptionLength",
            description: $"Breakfast description length is invalid(Must be at least {Models.Breakfast.MinDescriptionLength} and at most {Models.Breakfast.MaxDescriptionLength} characters long)"
        );
        
    }
}