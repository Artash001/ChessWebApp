var sourceSquare;

function drag(ev)
{
    // Set the data to be transferred during drag  
    ev.dataTransfer.setData("text/plain", ev.target.innerText);

    // Set the source square
    sourceSquare = String.fromCharCode(65 + ev.target.parentElement.cellIndex - 1) + (9 - ev.target.parentElement.parentElement.rowIndex);
}

function allowDrop(ev)
{
    // Prevent the default behavior to allow dropping
    ev.preventDefault();
}

function drop(ev)
{
    // Prevent the default behavior
    ev.preventDefault();

    // Set the destination square
    var destinationSquare = String.fromCharCode(65 + ev.target.cellIndex - 1) + (9 - ev.target.parentElement.rowIndex);

    // Log the source and destination squares
    console.log("Source Square: " + sourceSquare);
    console.log("Destination Square: " + destinationSquare);

    // Set the destination coordinate in the hidden input field
    document.getElementById('destinationCoordinate').value = destinationSquare;
    document.getElementById('selectedCordinate').value = sourceSquare;

    // Submit the form
    document.forms[0].submit();
}