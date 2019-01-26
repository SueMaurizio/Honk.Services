<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LocationTestPage.aspx.cs" Inherits="Tests.LocationTestPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Locations test page</title>
    </head>
    <body>
        <div>
            <h2>Get locations</h2>
            <ul id="locations"></ul>
        </div>

        <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.3.min.js"></script>
        <script>
            var uri = 'http://localhost/Honk Services/api/locations';

            $(document).ready(function () {
                // Send an AJAX request
                $.getJSON(uri)
                    .done(function (data) {
                    // On success, 'data' contains a list of products.
                    $.each(data, function (key, item) {
                        // Add a list item for the product.
                        $('<li>', { text: formatItem(item) }).appendTo($('#locations'));
                    });
                    });
            });

            function formatItem(item) {
                return item.Name + ': $' + item.Price;
            }
        </script>
    </body>
</html>
