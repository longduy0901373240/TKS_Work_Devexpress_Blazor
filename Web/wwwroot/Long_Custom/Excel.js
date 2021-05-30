window.saveAsFile = function (fileName, byteBase64) {
    var link = this.document.createElement('a');
    link.download = fileName;
    link.href = "data:application/octet-stream;base64," + byteBase64;
    this.document.body.appendChild(link);
    link.click();
    this.document.body.removeChild(link);
    alert("Downloaded");
}
window.saveFile = function (bytesBase64, mimeType, fileName) {
    var fileUrl = "data:" + mimeType + ";base64," + bytesBase64;
    fetch(fileUrl)
        .then(response => response.blob())
        .then(blob => {
            var link = window.document.createElement("a");
            link.href = window.URL.createObjectURL(blob, { type: mimeType });
            link.download = fileName;
            document.body.appendChild(link);
            link.click();
            document.body.removeChild(link);
        });
}
function downloadFile(b64Data, contentType, fileName) {
    const byteCharacters = atob(b64Data);
    const byteArrays = [];
    var sliceSize = 512;

    for (let offset = 0; offset < byteCharacters.length; offset += sliceSize) {
        const slice = byteCharacters.slice(offset, offset + sliceSize);

        const byteNumbers = new Array(slice.length);
        for (let i = 0; i < slice.length; i++) {
            byteNumbers[i] = slice.charCodeAt(i);
        }

        const byteArray = new Uint8Array(byteNumbers);
        byteArrays.push(byteArray);
    }

    var fName = fileName;
    var blob = new Blob(byteArrays, { type: contentType });
    if (window.navigator.msSaveBlob) {
        window.navigator.msSaveBlob(blob, fName);
    } else {
        var link = document.createElement("a");
        link.download = fName;

        if (link.download !== undefined) {
            var url = window.URL.createObjectURL(blob);
            link.setAttribute("href", url);
            link.setAttribute("download", fName);
            link.style.visibility = 'hidden';
            document.body.appendChild(link);
            link.click();
            document.body.removeChild(link);
            window.URL.revokeObjectURL(url);
        }
    }
}