/**
 * Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
 */

export function evenOrOdd(n:number):string {
    let msg: string = "Odd";
    
    if (n % 2 === 0 ){
      msg = "Even"
      return msg;
    }
    
    return msg;
  }