// function findShort(s){
//   let arr = s.split(" ");
//   let minLength = arr[0].length;
//   for(i of arr){
//     if(i.length < minLength){
//       minLength = i.length;
//     }
//   }
//   return minLength;
// }

function findShort(s){
    return Math.min(...s.split(" ").map(s => s.length));
}

console.log(findShort("world wide web"));
