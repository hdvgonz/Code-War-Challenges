export function isIsogram(str: string): boolean{
  
  str = str.toLowerCase();
  
  let status: boolean = false;
  
  let newStr = new Set(str);
  
  if (newStr.size === str.length) status = true;
  if (str === "") status = true;
  
  return status;
  
}
