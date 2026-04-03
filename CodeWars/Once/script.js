function once(fn) {
  let called = false;
  return function(...args){
    if(!called){
      called = true;
      let res = fn.apply(this, args);
      return res;
    }
    else{
      return undefined;
    }
  }
}

