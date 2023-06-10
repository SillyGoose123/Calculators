#[macro_use] extern crate text_io;

fn main() {
    println!("Welcome to Calc in Rust!");
    println!("Type \"exit\" to exit.");

    loop {
        print!(">");
        let line: String = read!("{}\n");

        if line.contains("exit") {
            break;
        }

        if line.contains("+"){
            calc("+", line);
        } else if line.contains("-") {
            calc("-", line);
        } else if line.contains("/") {
            calc("/", line);
        } else if line.contains("*") {
            calc("*", line);
        } else if line.contains("%") {
            calc("%", line);
        } else {
            println!("No operator or not supported operator.");
        }

    }

}

fn calc(regex: &str, line: String) {
    let collection: Vec<&str> = line.split(regex).collect();
    let num1: f32 = collection[0].trim().parse().unwrap();
    let num2: f32 = collection[1].trim().parse().unwrap();

    match regex {
        "+" => println!("{}" , num1 + num2),
        "-" => println!("{}" , num1 - num2),
        "/" => println!("{}" , num1 / num2),
        "*" => println!("{}" , num1 * num2),
        "%" => println!("{}" , num1 % num2),
        _ => {}
    }

}
