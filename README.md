# Blazor Component Communication and Dataflow
Welcome to the Blazor Component Communication and Dataflow repository! This project demonstrates various techniques to handle communication and data flow between Blazor components.

**Features Covered**:
* **Parameters**: Passing data from parent to child components.
* **Event Callbacks**: Sending responses from child components back to the parent.
* **Cascading Parameters**: Sharing data across multiple components without direct reference.
* **Services**: Facilitating communication between non-related components.

## Add the following in your project wwwroot folder -> index.html file's head section:
```csharp
<!-- Add MudBlazor CSS -->
<link href="https://cdn.jsdelivr.net/npm/mudblazor@5.2.0/dist/mudblazor.min.css" rel="stylesheet" />

<!-- Add MudBlazor JS -->
<script src="https://cdn.jsdelivr.net/npm/mudblazor@5.2.0/dist/mudblazor.min.js"></script>

<!-- Add Fonts -->
<link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;500&display=swap" rel="stylesheet" />
```

## Add the following in MainLayout.razor file:
```csharp
@* Required *@
<MudThemeProvider />
<MudPopoverProvider />

@* Needed for dialogs *@
<MudDialogProvider />

@* Needed for snackbars *@
<MudSnackbarProvider />
```

## Add the following in Program.cs:
```csharp
using MudBlazor.Services;
builder.Services.AddMudServices();
```

## 1. Parameters
![Parameters](https://github.com/AlienWashim/Blazor-Component-Communication-and-DataFlow/blob/9dcb480cf5f60485a3c4971c6deb6fc46f5d8acd/Parameter.png)
## 1. Cascading
![Cascading](https://github.com/AlienWashim/Blazor-Component-Communication-and-DataFlow/blob/9dcb480cf5f60485a3c4971c6deb6fc46f5d8acd/Cascading.png)
## 1. Services
![Services](https://github.com/AlienWashim/Blazor-Component-Communication-and-DataFlow/blob/9dcb480cf5f60485a3c4971c6deb6fc46f5d8acd/Service%202%20child.png)
