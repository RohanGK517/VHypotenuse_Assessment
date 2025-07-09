function calculateGrade() {
  let marks = [];
  for (let i = 1; i <= 5; i++) {
    let mark = parseInt(document.getElementById(`sub${i}`).value);
    if (isNaN(mark)) {
      document.getElementById("result").innerText = "Please enter valid numbers in all fields.";
      return;
    }
    marks.push(mark);
  }

  let total = 0;
  for (let i = 0; i < marks.length; i++) {
    total += marks[i];
  }

  let average = total / marks.length;
  let grade = "";

  if (average >= 90) grade = "A";
  else if (average >= 80) grade = "B";
  else if (average >= 70) grade = "C";
  else if (average >= 60) grade = "D";
  else grade = "F";

  document.getElementById("result").innerText =
    `Average Marks: ${average}\nGrade: ${grade}`;
}
