function capitals (word: string): number[] {
	
  const result: number[] = [];


for (let i = 0; i < word.length; i++){

  if (word.charCodeAt(i) >= 45 && word.charCodeAt(i) <= 90) result.push(i);
}

  return result;
}

/*
Instructions
Write a function that takes a single string (word) as argument. The function must return an ordered list containing the indexes of all capital letters in the string.

Example (Input --> Output)
"CodEWaRs" --> [0,3,4,6]
*/
