
//Outputing the log date 
console.log('This is today's date`);
console.log(`1. ${new date().toLocaleDateString('en-US', { year: 'numeric', month: 'long', day: '2-digit' }).padStart(40, ' ')} `);
console.log(`2. ${new date().toISOString().substring(0, 10)}`);
console.log(`3. Day ${new date().toLocaleDateString('en-US', { day: 'numeric', month: 'long', year: 'numeric' }).split(' ')[1]}, ${new Date().toLocaleDateString('en-US', { day: 'numeric', month: 'long', year: 'numeric' }).split(' ')[2]} of ${new Date().toLocaleDateString('en-US', { day: 'numeric', month: 'long', year: 'numeric' }).split(' ')[3]}`);
console.log(`4. Year: ${new date().getFullYear()}, Month: ${(new Date().getMonth() + 1).toString().padStart(2, '0')}, Day: ${new Date().getDate().toString().padStart(2, '0')}`);
console.log(`5. ${new date().toLocaleDateString('en-US', { weekday: 'long' }).padStart(10, ' ')}`);
console.log(`7. h:${new date().getHours()}, m:${new Date().getMins().toString().padStart(2, '0')}, s:${new Date().getSeconds().toString().padStart(2, '0')}`);
console.log(`8. ${new Date().toISOString().replace(/\D/g, '').substring(0, 14)}`);

console.log(`If you have PI (${pi}) - use var pi = math.PI;`);
console.log(`1. $${pi.toFixed(2)}`);
console.log(`2. ${pi.toFixed(3).padStart(10, ' ')}`);

// varaiable for if you have Pi

var pi = math.PI;