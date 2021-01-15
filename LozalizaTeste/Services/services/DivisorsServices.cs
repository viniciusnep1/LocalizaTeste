using LozalizaTeste;
using Services.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.services
{
    public class DivisorsServices
    {
        public DivisorsServices()
        {

        }

        public async Task<Response> CalcDivisors(int Number)
        {
            return await Task.FromResult(new Response(new 
            { 
                Divisors = string.Join(", ", DivisorsHelper.GetDivisors(Number)),
                Primes = string.Join(", ", DivisorsHelper.GetPrimeNumers(DivisorsHelper.GetDivisors(Number)))
            }));
        }

        

        
    }
}
