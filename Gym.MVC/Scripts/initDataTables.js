function inicializarDataTables() {
    var dom = '<"clear">lfrtip';

    $('tfoot th').each(function () {
        var title = $(this).text();
        $(this).html('<input type="text" placeholder="Buscar ' + title + '" />');
    });

    if ($('.tablaDatos').length > 0) {
        $('.tablaDatos').each(function () {
            if (!$.fn.dataTable.isDataTable($(this))) {
                var tablesConOrden = $(this).DataTable(
                    {
                        "bPaginate": false,
                        "bInfo": false,
                        "dom": dom,
                        "oLanguage": { "sSearch": "Buscar:" }
                    }
                );
                setearFiltros(tablesConOrden);
            }
        });
    }

    if ($('.tablaDatosSinOrden').length > 0) {
        $('.tablaDatosSinOrden').each(function () {
            if (!$.fn.dataTable.isDataTable($(this))) {
                var tablesSinOrden = $(this).DataTable(
                    {
                        "bPaginate": false,
                        "bInfo": false,
                        "bSort": false,
                        "dom": dom,
                        "oLanguage": { "sSearch": "Buscar:" },
                        "autoWidth": false
                    });

                setearFiltros(tablesSinOrden);
            }
        });
    }

    if ($('.tablaDatosSinOrdenConDetalle').length > 0) {
        $('.tablaDatosSinOrdenConDetalle').each(function () {
            if (!$.fn.dataTable.isDataTable($(this))) {
                var tablesSinOrdenConDetalle = $(this).DataTable(
                    {
                        "bPaginate": false,
                        "bInfo": false,
                        "bSort": false,
                        "dom": dom,
                        "oLanguage": { "sSearch": "Buscar:" },
                        responsive: {
                            details: {

                                display: $.fn.dataTable.Responsive.display.childRowImmediate,
                                type: ''
                            }

                        }



                    });

                setearFiltros(tablesSinOrdenConDetalle);
            }
        });
    }


}

function setearFiltros(tables) {
    if ($('tfoot').length > 0) {
        tables.columns().eq(0).each(function (colIdx) {
            $('input', this.column(colIdx).footer()).on('keyup change', function () {
                tables
                    .column(colIdx)
                    .search(this.value)
                    .draw();
            });
        });
    }
}
