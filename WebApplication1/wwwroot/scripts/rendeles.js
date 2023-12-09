
const apiUrl = "https://localhost:7149/index.html";
const apiResultsElement = document.getElementById("apiResults");

fetch('https://localhost:7149/index.html')
    .then(response => response.json())
    .then(data => { displayResults(data); });
    

function displayResults(results) {

    document.getElementById("apiResults");

}