package BaiTap2;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class bai02 {

	public static void main(String[] args) {
		 // Step 1 - File
        File file = new File("F:\\JAVA\\IO_File\\src\\BaiTap2\\data_Shape.txt");
        FileReader fr = null;
        BufferedReader br = null;
        try {
            // Step 2: Make a file reader
            fr = new FileReader(file);
            
            // Step 3: Make a buffer to read data
            br = new BufferedReader(fr);
            
            // Step 4: Read data from buffer to variable
            String data;
            // First line: row - column
            //data = br.readLine();
//            String[] datas = data.split(" ");
//            if (datas.length != 2){
//                System.out.println("Error: format data incorrect!");
//                return;
//            }
//            int row = 0;
//            int col = 0;
//            try{
//                row = Integer.parseInt(datas[0].trim());
//                col = Integer.parseInt(datas[1].trim());
//            }catch (NumberFormatException e){
//                System.out.println("Error: number format incorrect!");
//                return;
//            }
//            if (row <=0 || col <= 0){
//                System.out.println("Error: row or column is not validate!");
//                return;
//            }
            int row1 = 0;
            int	row2 = 0;
            double[][] matrixThang = new double[10][2];
            double[][] matrixTron = new double[10][3];
            int i = 0;
            String[] datas = null;
            while ((data = br.readLine())!= null){
                datas = data.split(" ");
//                if (datas.length != 2 | datas.length != 3){
//                    System.out.println("Error: format data incorrect!");
//                    return;
//                }
                if (datas.length == 2) {
                	
                try{
                    for (int j = 0; j < 2; j++) {
                    	double value = Double.parseDouble(datas[j].trim());
                        matrixThang[row1][j] = value;
                    }
                    row1++;
                }catch (NumberFormatException e){
                    System.out.println("Error: number format incorrect!");
                    return;
                }
                i++;
               } else if (datas.length == 3) {
                        try{
                            for (int j = 0; j< 3; j++) {
                                double value = Double.parseDouble(datas[j].trim());
                                matrixTron[row2][j] = value;
                            }
                            row2++;
                        }catch (NumberFormatException e){
                            System.out.println("Error: number format incorrect!");
                            return;
                        }
                        i++;
                       }
            }
            if (i!=5){
                System.out.println("Error: format data incorrect!");
                return;
            }
            //show
            System.out.println("Danh sách các đường thẳng");
            for (int j = 0; j < row1; j++) {
            	for (int k = 0; k < 2; k++) {
        			System.out.print(matrixThang[j][k] + " ");
        		}
            	System.out.println();
    		}
            
            System.out.println("Danh sách các đường tròn");
            for (int j = 0; j < row2; j++) {
            	for (int k = 0; k < 3; k++) {
        			System.out.print(matrixTron[j][k] + " ");
        		}
            	System.out.println();
    		}
            
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e){
            e.printStackTrace();
        } finally{
            // Step 6: Close all connections
            try {
                br.close();
                fr.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
        
        //show
        
        
	}

}
