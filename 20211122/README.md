- Añadido Views / Home / Mensaje.cshtml

	```html
	Hola, esto es un mensaje

	<p>@ViewBag.Nombre</p>
	```

- Modificado Controllers / HomeController.cs

	```cs
	public IActionResult Mensaje()
	{
		ViewBag.Nombre = "Mensaje de alguien";
		return View();
	}
	```

- Añadida tabla a Views / Home / Index.cshtml

    ```html
    <table>
        <tr>
            <td>dato1</td>
            <td>dato2</td>
        </tr>
        <tr>
            <td>dato3</td>
            <td>dato4</td>
        </tr>
    </table>
    ```

- Añadida entrada al menú en Views / Home / Shared / _Layout.cshtml

	```html
	<li class="nav-item">
		<a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Mensaje">Mensaje</a>
	</li>
	```
