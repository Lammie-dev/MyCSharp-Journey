document.getElementById('studentData').addEventListener('submit', function(e){ e.preventDefault();
const name = document.getElementById('name').value;
const gender = document.getElementById('gender').value;
const scoreInput = document.querySelectorAll('.score');

const scores = Array.from(scoreInput).map(input=>Number(input.value));
const studentData = {
  name: name,
  gender: gender,
  scores: scores
};


fetch('http://localhost:5000/api/students', {
  method: 'POST',
  headers: { 
    'Content-Type': 'application/json'
  },
  body:JSON.stringify(studentData)
})
.then(response => response.json())
.then(data => {
  document.querySelector('.display').innerHTML = `<p>
  Student: <strong>${data.name}<strong><br>
 Gender: <strong>${data.gender}</strong><br>
 Average: <strong>${data.average.toFixed(2)}</strong><br>
 Grade: <strong>${data.grade}</strong>

  </p>`;
})
.catch(err => {
  document.querySelector('.display').innerHTML = `Error Note: ${err.message};`
});

});