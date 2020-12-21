var piUrl = "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"

function embeberPDF() {
    PDFObject.embed(previsualizarPDF(), "#pdfContainer");
}

function previsualizarPDF() {
    var doc = new jsPDF();
    doc.setFont("helvetica");
    doc.setFontSize(12);
    if (logoUrl != null) {
        doc.addImage(logoUrl, "JPEG", 15, 10, 30, 30);
    }
    else {
        doc.addImage(piUrl, "JPEG", 15, 10, 30, 30);
    }
    var membrete = [];
    membrete.push($("#empresa").val());
    membrete.push("Dirección:");
    membrete.push($("#direccion").val());
    membrete.push($("#ciudad").val() + ", " + $("#estado").val() + ". (" + $("#pais").val() + ")");
    doc.text(membrete, 60, 20, 'left');

    var fechaYHora = [];
    fechaYHora.push($("#fecha").val());
    fechaYHora.push($("#hora").val());
    doc.text(fechaYHora, 200, 50, 'right');

    var destinatario = [];
    destinatario.push($("#tratamiento").val() + " " + $("#nombres").val() + " " + $("#apellidos").val());
    destinatario.push($("#direccion2").val());
    destinatario.push($("#ciudad2").val() + ", " + $("#estado2").val() + ". (" + $("#pais2").val() + ")");
    doc.text(destinatario, 15, 70, 'left');

    var saludo = $("#saludo").val() + ":"
    doc.text(saludo, 15, 90, 'left');

    //html2canvas($("#sampleeditor"), {
    //    onrendered: function (canvas) {
    //        var imgData = canvas.toDataURL(
    //            'image/png');
    //        doc.addImage(imgData, 'PNG', 15, 110);
    //        doc.save('sample-file.pdf');
    //    }
    //});

    var despedida = $("#despedida").val() + ","
    doc.text(despedida, 15, 200, 'left');
    if (firmaUrl != null) {
        doc.addImage(firmaUrl, "JPEG", 15, 210, 150, 30);
    }
    else {
        doc.addImage(piUrl, "JPEG", 15, 210, 150, 30);
    }
    var firma = [];
    firma.push("__________________________________________");
    firma.push($("#nombres2").val() + " " + $("#apellidos2").val());
    firma.push($("#cargo").val());
    doc.text(firma, 15, 260, 'left');
    return doc.output('datauristring');
}


function descargarPDF() {
    var doc = new jsPDF();
    doc.setFont("helvetica");
    doc.setFontSize(12);
    if (logoUrl != null) {
        doc.addImage(logoUrl, "JPEG", 15, 10, 30, 30);
    }
    else {
        doc.addImage(piUrl, "JPEG", 15, 10, 30, 30);
    }
    var membrete = [];
    membrete.push($("#empresa").val());
    membrete.push("Dirección:");
    membrete.push($("#direccion").val());
    membrete.push($("#ciudad").val() + ", " + $("#estado").val() + ". (" + $("#pais").val() + ")");
    doc.text(membrete, 60, 20, 'left');

    var fechaYHora = [];
    fechaYHora.push($("#fecha").val());
    fechaYHora.push($("#hora").val());
    doc.text(fechaYHora, 200, 50, 'right');

    var destinatario = [];
    destinatario.push($("#tratamiento").val() + " " + $("#nombres").val() + " " + $("#apellidos").val());
    destinatario.push($("#direccion2").val());
    destinatario.push($("#ciudad2").val() + ", " + $("#estado2").val() + ". (" + $("#pais2").val() + ")");
    doc.text(destinatario, 15, 70, 'left');

    var saludo = $("#saludo").val() + ":"
    doc.text(saludo, 15, 90, 'left');  

    var despedida = $("#despedida").val() + ","
    doc.text(despedida, 15, 200, 'left');
    if (firmaUrl != null) {
        doc.addImage(firmaUrl, "JPEG", 15, 210, 150, 30);
    }
    else {
        doc.addImage(piUrl, "JPEG", 15, 210, 150, 30);
    }
    var firma = [];
    firma.push("__________________________________________");
    firma.push($("#nombres2").val() + " " + $("#apellidos2").val());
    firma.push($("#cargo").val());
    doc.text(firma, 15, 260, 'left');

    html2canvas($("#sampleeditor"), {
        onrendered: function (canvas) {
            var imgData = canvas.toDataURL(
                'image/png');
            doc.addImage(imgData, 'PNG', 15, 110);
            doc.save('sample-file.pdf');
        }
    });
}