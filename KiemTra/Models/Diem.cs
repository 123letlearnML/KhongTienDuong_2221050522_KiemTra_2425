// using System;


// public class Diem
// {
//     public int DiemA { get; set; }
//     public int DiemB { get; set; }
//     public int DiemC { get; set; }

//     public Diem( int diemA, int diemB, int diem)
//     {
//         this.DiemA = diemA;
//         this.DiemB = diemB;
//         this.DiemC = diemC;
//     }

//     public Diem() { }

//     public overrdiemAe string ToString()
//     {
//         return $"diemA: {DiemA}, diemB: {DiemB}, Diem: {DiemC}";
//     }
// }

namespace  KiemTra.Models;

using Microsoft.AspNetCore.Mvc;
public class Diem
{
    public int DiemA { get; set; }
    public int DiemB { get; set; }
    public int DiemC { get; set; }

    public Diem(int diemA, int diemB, int diemC)
    {
        this.DiemA = diemA;
        this.DiemB = diemB;
        this.DiemC = diemC;
    }

    public Diem() { }

    public override string ToString()
    {
        return $"DiemA: {DiemA}, DiemB: {DiemB}, DiemC: {DiemC}";
    }
}