class DiffieHellman{
    private readonly p: number;
    private readonly g: number;

    constructor(firstPrime: number, secondPrime: number){
        if(!this.isPrime(firstPrime) || !this.isPrime(secondPrime)){
            throw Error("Numbers provided are out of range or are not prime numbers!");
        }
        this.p = firstPrime;
        this.g = secondPrime;
    }

    public getPublicKeyFromPrivateKey(privateKey: number): number{
        if(privateKey <= 1 || privateKey >= this.p){
            throw Error("Private key is out of bounds!");
        }
        return this.g**privateKey % this.p;
    }
    
    public getSharedSecret(privateKey: number, publicKey: number): number{
        return publicKey**privateKey % this.p;
    }
    
    private isPrime(num : number): boolean{
        for(let i = 2 ; i <= Math.sqrt(num); i++){
            if(num % i === 0){
                return false; 
            } 
        }
        return num > 1;
    }
}

export default DiffieHellman