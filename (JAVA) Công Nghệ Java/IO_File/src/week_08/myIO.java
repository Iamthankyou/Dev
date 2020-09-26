package week_08;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class myIO {
	public static void main(String[] args) {
		File fi = new File("F:\\JAVA\\IO_File\\src\\week_08\\Example_3.txt");
		File fo = new File("F:\\JAVA\\IO_File\\src\\week_08\\Example_3_out.txt");
		int sum = readData(fi);
		
		int duong = demDuong(fi);
		
		writeData(fo, sum, duong);
		
	}
	public static int demDuong(File file) {
		int duong = 0;
		FileReader fr = null;
		
		BufferedReader br = null;
		
		String data;
		try {
			fr = new FileReader(file);
			
			br = new BufferedReader(fr);
			
			while((data = br.readLine()) != null) {
				try {
					String[] datas = data.split(":");
					
					for (String d : datas) {
						int value = Integer.parseInt(d);
						if (value > 0) duong++;
					}
				} catch (NumberFormatException e) {
					//NA
				}
			}
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}finally {
			try {
				br.close();
				fr.close();
			} catch (IOException e) {
			e.printStackTrace();
			}
		}
		return duong;
	}
	public static void writeData(File file, int sum, int n) {
		FileWriter fw = null;
		BufferedWriter bw = null;
		try {
			fw = new FileWriter(file);
			
			bw = new BufferedWriter(fw);
			
			bw.write("Tổng các số trong ma trận: ");
			bw.write(" " + sum);
			bw.newLine();
			bw.write("có " + n + " số dương");
			
		}catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
		finally {
			try {
				bw.close();
				fw.close();
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}

	public static int readData(File file) {
		FileReader fr = null;
		BufferedReader br = null;
		int sum = 0;
		try {
			fr = new FileReader(file);
			
			br = new BufferedReader(fr);
			
			String data;
			
			while((data = br.readLine())!= null) {
				try {
					System.out.println(data);
					String[] datas = data.split(":");
					for (String d : datas) {
						int value = Integer.parseInt(d);
						sum += value;
					}
				} catch (NumberFormatException e) {
					//NA
				}
			}
		}catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
		finally {
			try {
				br.close();
				fr.close();
			} catch (IOException e) {
				e.printStackTrace();
			}
		}

		return sum;
	}
}
