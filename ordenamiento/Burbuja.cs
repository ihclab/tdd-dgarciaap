﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ordenamiento {
    public class Burbuja {
        public void Ordenar(int[] arr) {
             for (int i = 1; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j >= i; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int aux = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = aux;
                    }
                }
            }
        }
    }
}
