
const apiUrl = "https://localhost:7149/index.html";
const apiResultsElement = document.getElementById("apiResults");

fetch(apiURL)
    .then(response => response.json())
    .then(data => { displayResults(data); })
    .catch(error => { console.error("API hivás közben hiba történt:", error); });

function displayResults(results) {
    // Töröld az esetleges előző eredményeket
    apiResultsElement.innerHTML = "";

    // Ellenőrizd, hogy az eredmények üresek-e
    if (results.length === 0) {
        apiResultsElement.innerHTML = "<p>Nincsenek eredmények.</p>";
        return;
    }