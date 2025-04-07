
window.onload = function () {
    let table = document.getElementById('GroupTable');
    let rows = document.getElementsByTagName('tr');

    for (let i = 1; i < table.rows.length; i++) {
        const firstnameCell = rows[i].children[1];
        const firstName = firstnameCell.textContent.trim();
        if (firstName.charAt(0).toUpperCase() === 'M') {
            rows[i].style.color = "red";
        }
    }
}
function deleteRow(button) {

    const row = button.parentNode.parentNode;
    row.parentNode.removeChild(row);
}
