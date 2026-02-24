namespace CopilotTraining.Application.DTOs;

public record OrderDto(
    Guid Id,
    Guid CustomerId,
    string CustomerName,
    List<OrderItemDto> Items,
    decimal TotalAmount,
    string Status,
    DateTime CreatedAt
);

public record OrderItemDto(
    Guid ProductId,
    string ProductName,
    int Quantity,
    decimal UnitPrice
);

public record CreateOrderRequest(
    Guid CustomerId,
    List<CreateOrderItemRequest> Items
);

public record CreateOrderItemRequest(
    Guid ProductId,
    int Quantity
);