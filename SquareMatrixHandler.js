function getRowsColsAndDiagsofSquareMatrix(s) {

    let rows = [0, 0, 0];
    let cols = [0, 0, 0];
    let diags = [0, 0];  //Left and right 

    for (let i = 0; i < s.length; i++) {

        diags[0] += s[i][i];
        diags[1] += s[i][2 - i];
        for (let j = 0; j < s.length; j++) {
            
            rows[i] += s[i][j];
            cols[i] += s[j][i];
            
        }
        

        
    }

    return [rows, cols, diags]
}
