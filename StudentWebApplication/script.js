document.getElementById("studentData").addEventListener("submit", function (e) {

  e.preventDefault();

  
  const name = document.getElementById("name").value;
  const gender = document.getElementById("gender").value;
  const scoreInput = document.querySelectorAll(".score");

  const scores = Array.from(scoreInput).map((input) => Number(input.value));
  const studentData = {
    name: name,
    gender: gender,
    scores: scores
  };
     
  
    
 
  fetch("http://localhost:5154/api/students", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(studentData)
  })
  
    .then((response) => response.json())
    .then((data) => {
      const showResult =
      document.getElementById("display");
      showResult.innerHTML = `<p>
  Student: <strong>${data.name}</strong><br>
 Gender: <strong>${data.gender}</strong><br>
 Average: <strong>${data.average.toFixed(2)}</strong><br>
 Grade: <strong>${data.grade}</strong>

  </p>`;
     loadStudents();
    })
    .catch((err) => {
      document.getElementById("display").innerText =
        "Error Note:" + err.message;
    });
});
 

  function loadStudents() {
    fetch("http://localhost:5154/api/students")
    .then(response => response.json())
    .then(data => {
      const studentList = 
      document.getElementById('studentList');
      if (data.length ===0) {
        studentList.innerHTML = `<p> No students found. </p>`;
        return;
      }
      let output= `<table border = '1' cellpadding ='8' > <tr><th>Name</th> <th>Gender</th> <th>Average</th> <th>Grade</th> </tr>`;
      data.forEach(s => { output += `<tr>
        <td>${s.name}</td>
        <td>${s.gender}</td>
        <td>${s.average.toFixed(2)}</td>
        <td>${s.grade}</td>
        </tr>`;
        
      }); 
      output += `</table>`;
      studentList.innerHTML = output;
    })
     .catch((err) => {
      document.getElementById("studentList").innerText =
        "Error fetching student lists:" + err.message;
    });
  }
  loadStudents();