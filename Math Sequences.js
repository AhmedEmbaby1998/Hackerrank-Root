function mathSequence(arr) {

    const math = arr[0] - arr[1];
    const geo = arr[1] / arr[0];
    let geoCount = 0;
    let mathCount = 0;

    for (let i = 0; i < arr.length; i++) {
        if(arr[i] - arr[i + 1] === math) {
            mathCount++;
        }

        if(arr[i + 1] / arr[i] === geo) {
           geoCount++
        }
    }
    if (mathCount + 1 === arr.length)
    return  "Arithmetic";

    if(geoCount + 1 === arr.length) {
        return  "Geometeric";
    }
    
    return "No pattern recognized!"
}
