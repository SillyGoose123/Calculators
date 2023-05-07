import java.util.regex.Pattern
import kotlin.system.exitProcess


fun main() {
    println("Hello from Calc in Kotlin!")
    println("Type \"exit\" to exit.")
    while (true) {
        print(">")
        val input = readlnOrNull()
        try {
            if (input != null) {
            
                if(input.contains("exit")){
                    exitProcess(0)
                }

                if (input.contains("+")) {
                    println(calc("+", input))
                } else if (input.contains("-")) {
                    println(calc("-", input))
                } else if (input.contains("/")) {
                    println(calc("/", input))
                } else if (input.contains("*")) {
                    println(calc("*", input))
                } else if (input.contains("%")) {
                    println(calc("%", input))
                } else {
                    println("No operator or not supported operator.")
                }
            } else {
                println("You need to type sth.")
            }
        } catch (e: Exception){
            println("You typed shit. $e")
        }
    }
}


fun calc(regex: String, input: String): Int {
    val add = intArrayOf(input.split(regex)[0].toInt(), input.split(regex)[1].toInt())
    when (regex) {
        "+" -> return add[0] + add[1]
        "-" -> return add[0] - add[1]
        "/" -> return add[0] / add[1]
        "*" -> return add[0] * add[1]
        "%" -> return add[0] % add[1]
    }
    return 0
}