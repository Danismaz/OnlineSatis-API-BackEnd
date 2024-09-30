namespace DataTransfer.Concrete;

public record UserForLoginDto
(
     string Name,
     string? Email,
     string? Password
);