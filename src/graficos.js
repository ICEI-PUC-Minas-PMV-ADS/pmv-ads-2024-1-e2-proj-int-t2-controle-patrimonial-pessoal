// Dados
const graficoRend = {
    labels: ['Investimentos', 'Salário', 'Outros'],
    datasets: [{
        data: [500, 1800, 200],
        backgroundColor: ['#FF6384', '#36A2EB', '#FFCE56']
    }]
};
const graficoOrc = {
    labels: ['Aluguel', 'Transporte', 'Alimentação'],
    datasets: [{
        data: [700, 500, 300],
        backgroundColor: ['#FF6384', '#36A2EB', '#FFCE56']
    }]
};
// Opções
const opcoes = {
    responsive: true,
    plugins: {
        legend: {
            position: 'bottom',
        },
        title: {
            display: true,
        }
    }
};
// Iniciando os gráficos
window.onload = function() {
    const pieRend = document.getElementById('grafico-rend');
    const pieOrc = document.getElementById('grafico-orc');
    new Chart(pieRend, {
        type: 'pie',
        data: graficoRend,
        options: opcoes
    });
    new Chart(pieOrc, {
        type: 'pie',
        data: graficoOrc,
        options: opcoes
    });
};