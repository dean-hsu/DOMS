$(function () {
    $("#familyId").change(function () {
        $.getJSON("../Catalogue/GetCatalogues",
            { familyId: $("#familyId").val() },
            function(data) {
                var items = "";
                $("#CatalogueId").empty();
                $.each(data,
                    function (i, catalogue) {
                        items += "<option value='" + catalogue.catalogueId + "'>" + catalogue.name + "</option>";
                    });
                $("#CatalogueId").html(items);
            });
    });

});