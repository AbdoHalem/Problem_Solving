function disemvowel(str) {
  let vowels = /[aieou]/gi;
  return str.replaceAll(vowels, '');
}
console.log(disemvowel("This website is for losers LOL!"));
