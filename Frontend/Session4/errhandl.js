try{
    const a = 10*4;
    console.log(a);
    myFunction(); 
}
catch(err){
    console.log("Err")
    console.error("An error occurred: " + err.message);
}