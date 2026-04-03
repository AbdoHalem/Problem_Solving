//? Logic Solution
// function solution(str){
//     let arr = str.split('');
//     let len = arr.length;
//     let limit = Math.floor(len/2);
//     console.log(limit);
//     for(let i = 0; i < limit; i++){
//         let temp = arr[i];
//         arr[i] = arr[len-1-i];
//         arr[len-1-i] = temp;
//     }
//     return arr.join('');
// }
//? Better Solution
function solution(str){
    return str.split('').reverse().join('');
}

console.log(solution("world"));
