//// See https://aka.ms/new-console-template for more information
//// Input PDF 
//using Courseify.PdfMan.Bookmarks;
//using Courseify.PdfMan.Bookmarks.Data;
//using Courseify.PdfMan.Text;
//using iText.Kernel.Pdf;
//using iText.StyledXmlParser.Jsoup.Nodes;
//using System.Diagnostics;
//using System.Text;
//using static Courseify.PdfMan.Bookmarks.IPdfBookmarkService;

//IPdfTextService textService = new PdfTextService();
//PdfBookmarkService bookmarkService = new PdfBookmarkService(textService);
//string PdfFilePath = "C:\\Users\\MSE\\Downloads\\PHYSICS 150 BOOK.pdf";
//using PdfReader reader = new PdfReader(PdfFilePath);
//PdfDocument doc = new(reader);
//var bookmarks = bookmarkService.GetBookmarksFromPdf(doc, true);
//tabsforchildren(bookmarks);
//// Go trhoigh the list of nodes using a for loop 
//void tabsforchildren(BookmarkNode Node, int indentation = 0)
//{
//    Console.WriteLine(new string('\t', indentation) + $"{Node.Title} ({Node.Id})");

//    foreach (var item in Node.Children)
//    {
//        tabsforchildren(item, indentation + 1);
//    }
//}


//Console.WriteLine();
//Console.Write("Enter chapter ID: ");
//// Read the chapter ID as an integer from the console
//// int chapterId = ...;

//int chapterId;
//while (!int.TryParse(Console.ReadLine(), out chapterId))
//{
//    Console.WriteLine("Invalid Try again");
//}


//// Get the text of that chapter using textService and store it in a string
//// string text = ...;

//var node =
//     ((BookmarkNode)bookmarks.FindNodeById(chapterId)!);
//StringBuilder text = new();
//void AddChildrenToText(BookmarkNode parent)
//{
//    text.AppendLine(parent.Text);
//    foreach (BookmarkNode item in parent!.Children)
//    {
//        AddChildrenToText((BookmarkNode)item);
//    }
//}

//AddChildrenToText(node);
//// Write this text to a file "output.txt"
//File.WriteAllText("output.txt", text.ToString());
//Console.WriteLine("Text has been written to output.txt");
using Courseify.OpenAI.Quiz;
using Rystem.OpenAi;

string text = @"
CHAPTER 27
Circuits
27-1 SINGLE-LOOP CIRCUITS
Learning Objectives 
After reading this module, you should be able to . . .
27.01 Identify the action of an emf source in terms of the 27.10 Calculate the potential difference between any two 
work it does. points in a circuit.
27.02 For an ideal battery, apply the relationship between the 27.11 Distinguish a real battery from an ideal battery and, 
emf, the current, and the power (rate of energy transfer). in a circuit diagram, replace a real battery with an ideal 
27.03 Draw a schematic diagram for a single-loop circuit battery and an explicitly shown resistance.
 containing a battery and three resistors. 27.12 With a real battery in a circuit, calculate the poten-
27.04 Apply the loop rule to write a loop equation that tial difference between its terminals for current in the 
relates the potential differences of the circuit elements direction of the emf and in the opposite direction.
around a (complete) loop. 27.13 Identify what is meant by grounding a circuit, and 
27.05 Apply the resistance rule in crossing through a resistor. draw a schematic diagram for such a connection.
27.06 Apply the emf rule in crossing through an emf. 27.14 Identify that grounding a circuit does not affect the 
27.07 Identify that resistors in series have the same current,  current in a circuit.
which is the same value that their equivalent resistor has. 27.15 Calculate the dissipation rate of energy in a real battery.
27.08 Calculate the equivalent of series  resistors. 27.16 Calculate the net rate of energy transfer in a real 
27.09 Identify that a potential applied to resistors wired in battery for current in the direction of the emf and in the 
 series is equal to the sum of the potentials across the opposite direction.
 individual resistors.
Key Ideas 
● An emf device does work on charges to maintain a loop of a circuit must be zero.
 potential difference between its output terminals. If dW is 
Conservation of charge leads to the junction rule (Chapter 26):
the work the device does to force positive charge dq from 
Junction Rule.  The sum of the currents entering any junction 
the negative to the positive terminal, then the emf (work 
must be equal to the sum of the currents leaving that junction.
per unit charge) of the device is
● When a real battery of emf ℰ and internal resistance r 
dW
ℰ =  (definition of ℰ).
does work on the charge carriers in a current i through the 
dq
battery, the rate P of energy transfer to the charge carriers is
● An ideal emf device is one that lacks any internal resis-
P = iV,
tance. The potential difference between its terminals is 
equal to the emf. where V is the potential across the terminals of the battery.
● A real emf device has internal resistance. The potential 
● The rate P at which energy is dissipated as thermal 
r
 difference between its terminals is equal to the emf only if 
energy in the battery is
there is no current through the device.
2
P = i r.
r
● The change in potential in traversing a resistance R in 
● The rate P at which the chemical energy in the battery 
emf
the direction of the current is –iR; in the  opposite direction 
changes is
it is +iR (resistance rule). 
P = iℰ.
emf
● The change in potential in traversing an ideal emf  device 
● When resistances are in series, they have the same current. 
in the direction of the emf arrow is +ℰ; in the opposite 
The equivalent resistance that can  replace a series combina-
direction it is –ℰ (emf rule). 
tion of resistances is
● Conservation of energy leads to the loop rule:
n
Loop Rule. The algebraic sum of the changes in   
R = ∑ R  (n resistances in series).
eq j
j=1
potential encountered in a complete traversal of any  
771
CHAPTER 27
Circuits
27-1 SINGLE-LOOP CIRCUITS
Learning Objectives 
After reading this module, you should be able to . . .
27.01 Identify the action of an emf source in terms of the 27.10 Calculate the potential difference between any two 
work it does. points in a circuit.
27.02 For an ideal battery, apply the relationship between the 27.11 Distinguish a real battery from an ideal battery and, 
emf, the current, and the power (rate of energy transfer). in a circuit diagram, replace a real battery with an ideal 
27.03 Draw a schematic diagram for a single-loop circuit battery and an explicitly shown resistance.
 containing a battery and three resistors. 27.12 With a real battery in a circuit, calculate the poten-
27.04 Apply the loop rule to write a loop equation that tial difference between its terminals for current in the 
relates the potential differences of the circuit elements direction of the emf and in the opposite direction.
around a (complete) loop. 27.13 Identify what is meant by grounding a circuit, and 
27.05 Apply the resistance rule in crossing through a resistor. draw a schematic diagram for such a connection.
27.06 Apply the emf rule in crossing through an emf. 27.14 Identify that grounding a circuit does not affect the 
27.07 Identify that resistors in series have the same current,  current in a circuit.
which is the same value that their equivalent resistor has. 27.15 Calculate the dissipation rate of energy in a real battery.
27.08 Calculate the equivalent of series  resistors. 27.16 Calculate the net rate of energy transfer in a real 
27.09 Identify that a potential applied to resistors wired in battery for current in the direction of the emf and in the 
 series is equal to the sum of the potentials across the opposite direction.
 individual resistors.
Key Ideas 
● An emf device does work on charges to maintain a loop of a circuit must be zero.
 potential difference between its output terminals. If dW is 
Conservation of charge leads to the junction rule (Chapter 26):
the work the device does to force positive charge dq from 
Junction Rule.  The sum of the currents entering any junction 
the negative to the positive terminal, then the emf (work 
must be equal to the sum of the currents leaving that junction.
per unit charge) of the device is
● When a real battery of emf ℰ and internal resistance r 
dW
ℰ =  (definition of ℰ).
does work on the charge carriers in a current i through the 
dq
battery, the rate P of energy transfer to the charge carriers is
● An ideal emf device is one that lacks any internal resis-
P = iV,
tance. The potential difference between its terminals is 
equal to the emf. where V is the potential across the terminals of the battery.
● A real emf device has internal resistance. The potential 
● The rate P at which energy is dissipated as thermal 
r
 difference between its terminals is equal to the emf only if 
energy in the battery is
there is no current through the device.
2
P = i r.
r
● The change in potential in traversing a resistance R in 
● The rate P at which the chemical energy in the battery 
emf
the direction of the current is –iR; in the  opposite direction 
changes is
it is +iR (resistance rule). 
P = iℰ.
emf
● The change in potential in traversing an ideal emf  device 
● When resistances are in series, they have the same current. 
in the direction of the emf arrow is +ℰ; in the opposite 
The equivalent resistance that can  replace a series combina-
direction it is –ℰ (emf rule). 
tion of resistances is
● Conservation of energy leads to the loop rule:
n
Loop Rule. The algebraic sum of the changes in   
R = ∑ R  (n resistances in series).
eq j
j=1
potential encountered in a complete traversal of any  
771
772 CHAPTER 27 CIRCUITS
What Is Physics?
You are surrounded by electric circuits. You might take pride in the number 
of electrical devices you own and might even carry a mental list of the devices 
you wish you owned. Every one of those devices, as well as the electrical grid 
that powers your home, depends on modern electrical engineering. We cannot 
easily estimate the current financial worth of electrical engineering and its prod-
ucts, but we can be certain that the financial worth continues to grow yearly as 
more and more tasks are handled electrically. Radios are now tuned electroni-
cally instead of manually. Messages are now sent by email instead of through 
the postal  system. Research journals are now read on a computer instead of in 
a library building, and research papers are now copied and filed electronically 
instead of photocopied and tucked into a filing cabinet. Indeed, you may be read-
ing an electronic version of this book.
The basic science of electrical engineering is physics. In this chapter we 
cover the physics of electric circuits that are combinations of resistors and bat-
teries (and, in Module 27-4, capacitors). We restrict our discussion to circuits 
through which charge flows in one direction, which are called either direct- 
current circuits or DC circuits. We begin with the question: How can you get 
charges to flow?
“Pumping” Charges
If you want to make charge carriers flow through a resistor, you must establish 
a potential difference between the ends of the device. One way to do this is to 
connect each end of the resistor to one plate of a charged capacitor. The trouble 
with this scheme is that the flow of charge acts to discharge the capacitor, quickly 
bringing the plates to the same potential. When that happens, there is no longer 
an electric field in the resistor, and thus the flow of charge stops.
To produce a steady flow of charge, you need a “charge pump,” a device 
that—by doing work on the charge carriers—maintains a potential difference 
between a pair of terminals. We call such a device an emf device, and the device 
is said to provide an emf ℰ, which means that it does work on charge carriers. 
An emf device is sometimes called a seat of emf. The term emf comes from the 
outdated phrase electromotive force, which was adopted before scientists clearly 
understood the function of an emf device.
In Chapter 26, we discussed the motion of charge carriers through a circuit 
in terms of the electric field set up in the circuit—the field produces forces that 
move the charge carriers. In this chapter we take a different approach: We discuss 
the motion of the charge carriers in terms of the required energy — an emf device 
supplies the energy for the motion via the work it does.
A common emf device is the battery, used to power a wide variety of 
 machines from wristwatches to submarines. The emf device that most influ-
ences our daily lives, however, is the electric generator, which, by means of 
electrical connections (wires) from a generating plant, creates a potential dif-
ference in our homes and workplaces. The emf devices known as solar cells, 
long familiar as the wing-like panels on spacecraft, also dot the countryside 
for domestic applications. Less familiar emf devices are the fuel cells that 
powered the space shuttles and the thermopiles that provide onboard elec-
trical power for some spacecraft and for remote stations in Antarctica and  
elsewhere. An emf device does not have to be an instrument — living systems, 
ranging from electric eels and human beings to plants, have physiological emf 
devices.
Although the devices we have listed differ widely in their modes of opera-
tion, they all perform the same basic function—they do work on charge carriers 
and thus maintain a potential difference between their terminals.
772 CHAPTER 27 CIRCUITS
What Is Physics?
You are surrounded by electric circuits. You might take pride in the number 
of electrical devices you own and might even carry a mental list of the devices 
you wish you owned. Every one of those devices, as well as the electrical grid 
that powers your home, depends on modern electrical engineering. We cannot 
easily estimate the current financial worth of electrical engineering and its prod-
ucts, but we can be certain that the financial worth continues to grow yearly as 
more and more tasks are handled electrically. Radios are now tuned electroni-
cally instead of manually. Messages are now sent by email instead of through 
the postal  system. Research journals are now read on a computer instead of in 
a library building, and research papers are now copied and filed electronically 
instead of photocopied and tucked into a filing cabinet. Indeed, you may be read-
ing an electronic version of this book.
The basic science of electrical engineering is physics. In this chapter we 
cover the physics of electric circuits that are combinations of resistors and bat-
teries (and, in Module 27-4, capacitors). We restrict our discussion to circuits 
through which charge flows in one direction, which are called either direct- 
current circuits or DC circuits. We begin with the question: How can you get 
charges to flow?
“Pumping” Charges
If you want to make charge carriers flow through a resistor, you must establish 
a potential difference between the ends of the device. One way to do this is to 
connect each end of the resistor to one plate of a charged capacitor. The trouble 
with this scheme is that the flow of charge acts to discharge the capacitor, quickly 
bringing the plates to the same potential. When that happens, there is no longer 
an electric field in the resistor, and thus the flow of charge stops.
To produce a steady flow of charge, you need a “charge pump,” a device 
that—by doing work on the charge carriers—maintains a potential difference 
between a pair of terminals. We call such a device an emf device, and the device 
is said to provide an emf ℰ, which means that it does work on charge carriers. 
An emf device is sometimes called a seat of emf. The term emf comes from the 
outdated phrase electromotive force, which was adopted before scientists clearly 
understood the function of an emf device.
In Chapter 26, we discussed the motion of charge carriers through a circuit 
in terms of the electric field set up in the circuit—the field produces forces that 
move the charge carriers. In this chapter we take a different approach: We discuss 
the motion of the charge carriers in terms of the required energy — an emf device 
supplies the energy for the motion via the work it does.
A common emf device is the battery, used to power a wide variety of 
 machines from wristwatches to submarines. The emf device that most influ-
ences our daily lives, however, is the electric generator, which, by means of 
electrical connections (wires) from a generating plant, creates a potential dif-
ference in our homes and workplaces. The emf devices known as solar cells, 
long familiar as the wing-like panels on spacecraft, also dot the countryside 
for domestic applications. Less familiar emf devices are the fuel cells that 
powered the space shuttles and the thermopiles that provide onboard elec-
trical power for some spacecraft and for remote stations in Antarctica and  
elsewhere. An emf device does not have to be an instrument — living systems, 
ranging from electric eels and human beings to plants, have physiological emf 
devices.
Although the devices we have listed differ widely in their modes of opera-
tion, they all perform the same basic function—they do work on charge carriers 
and thus maintain a potential difference between their terminals.
27-1 SINGLE-LOOP CIRCUITS 773
a
i
Work, Energy, and Emf
Figure 27-1 shows an emf device (consider it to be a battery) that is part of a 
a'
 simple circuit containing a single resistance R (the symbol for resistance and a 
+
i
 resistor is ). The emf device keeps one of its terminals (called the positive R
–
terminal and often labeled +) at a higher electric potential than the other termi-
nal (called the negative terminal and labeled –). We can represent the emf of the 
 device with an arrow that points from the negative terminal toward the positive 
i
terminal as in Fig. 27-1. A small circle on the tail of the emf arrow distinguishes it 
from the arrows that indicate current direction. Figure 27-1 A simple electric circuit, in 
which a device of emf ℰ does work on 
When an emf device is not connected to a circuit, the internal chemistry of 
the charge carriers and maintains a steady 
the device does not cause any net flow of charge carriers within it. However, 
 current i in a resistor of  resistance R.
when it is connected to a circuit as in Fig. 27-1, its internal chemistry causes a net 
flow of positive charge carriers from the negative terminal to the positive termi-
nal, in the direction of the emf arrow. This flow is part of the current that is set up 
around the circuit in that same direction (clockwise in Fig. 27-1).
Within the emf device, positive charge carriers move from a region of low 
electric potential and thus low electric potential energy (at the negative terminal) 
to a region of higher electric potential and higher electric potential energy (at 
the positive terminal). This motion is just the opposite of what the electric field 
 between the terminals (which is directed from the positive terminal toward the 
negative terminal) would cause the charge carriers to do.
Thus, there must be some source of energy within the device, enabling it to 
do work on the charges by forcing them to move as they do. The energy source 
may be chemical, as in a battery or a fuel cell. It may involve mechanical forces, 
as in an electric generator. Temperature differences may supply the energy, as in 
a thermopile; or the Sun may supply it, as in a solar cell.
Let us now analyze the circuit of Fig. 27-1 from the point of view of work and 
energy transfers. In any time interval dt, a charge dq passes through any cross 
  A i
– +
section of this circuit, such as aaʹ. This same amount of charge must enter the 
A
emf device at its low-potential end and leave at its high-potential end. The device 
M
must do an amount of work dW on the charge dq to force it to move in this way. R
i
We define the emf of the emf device in terms of this work:
B
– +
dW i
   B
 ℰ =  (definition of ℰ). (27-1)
dq
In words, the emf of an emf device is the work per unit charge that the device 
m
does in moving charge from its low-potential terminal to its high-potential 
(a)
 terminal. The SI unit for emf is the joule per coulomb; in Chapter 24 we defined 
that unit as the volt.
An ideal emf device is one that lacks any internal resistance to the internal 
Work done
movement of charge from terminal to terminal. The potential difference between by motor
on mass m
the terminals of an ideal emf device is equal to the emf of the device. For exam-
ple, an ideal battery with an emf of 12.0 V always has a potential difference of 
12.0 V between its terminals. Chemical Thermal energy
energy lost produced
A real emf device, such as any real battery, has internal resistance to the 
by B by resistance R
 internal movement of charge. When a real emf device is not connected to a circuit,  
and thus does not have current through it, the potential difference between its  
Chemical
terminals is equal to its emf. However, when that device has current through it, 
energy stored
the potential difference between its terminals differs from its emf. We shall dis-
in A
cuss such real batteries near the end of this module.
(b)
When an emf device is connected to a circuit, the device transfers energy to 
the charge carriers passing through it. This energy can then be transferred from 
Figure 27-2 (a) In the circuit, ℰ > ℰ ; 
B A
the charge carriers to other devices in the circuit, for example, to light a bulb. 
so battery B determines the direction of 
Figure 27-2a shows a circuit containing two ideal rechargeable (storage) batteries  
the current. (b) The energy transfers in 
A and B, a resistance R, and an electric motor M that can lift an object by using the circuit.
774 CHAPTER 27 CIRCUITS
energy it obtains from charge carriers in the circuit. Note that the batteries are con-
nected so that they tend to send charges around the circuit in opposite directions. 
The actual direction of the current in the circuit is determined by the  battery with 
the larger emf, which happens to be battery B, so the chemical  energy within bat-
tery B is decreasing as energy is transferred to the charge carriers passing through  
it. However, the chemical energy within battery A is  increasing because the cur-
rent in it is directed from the positive terminal to the negative terminal. Thus, 
battery B is charging battery A. Battery B is also pro viding energy to motor M 
and energy that is being dissipated by resistance R. Figure 27-2b shows all three 
energy transfers from battery B; each decreases that battery’s chemical energy.
Calculating the Current in a Single-Loop Circuit
We discuss here two equivalent ways to calculate the current in the simple single-
loop circuit of Fig. 27-3; one method is based on energy conservation considerations, 
and the other on the concept of potential. The circuit consists of an ideal battery B 
with emf ℰ, a resistor of resistance R, and two connecting wires. (Unless otherwise 
indicated, we assume that wires in circuits have negligible resistance. Their function, 
then, is merely to provide pathways along which charge carriers can move.)
Energy Method
2
Equation 26-27 (P = i R) tells us that in a time interval dt an amount of energy 
2
given by i R dt will appear in the resistor of Fig. 27-3 as thermal energy. As noted 
in Module 26-5, this energy is said to be dissipated. (Because we assume the wires 
to have negligible resistance, no thermal energy will appear in them.) During the 
same interval, a charge dq = i dt will have moved through battery B, and the work 
that the battery will have done on this charge, according to Eq. 27-1, is
dW = ℰ dq = ℰi dt.
From the principle of conservation of energy, the work done by the (ideal) bat-
tery must equal the thermal energy that appears in the resistor:
2
ℰi dt = i R dt.
This gives us
ℰ = iR.
The emf ℰ is the energy per unit charge transferred to the moving charges by the 
battery. The quantity iR is the energy per unit charge transferred from the mov-
ing charges to thermal energy within the resistor. Therefore, this equation means 
that the energy per unit charge transferred to the moving charges is equal to the 
energy per unit charge transferred from them. Solving for i, we find
The battery drives current
through the resistor, from
ℰ
high potential to low potential.
 i = . (27-2)
R
i
Higher
potential
+
Potential Method
i
B R
–
Suppose we start at any point in the circuit of Fig. 27-3 and mentally proceed 
a
Lower
around the circuit in either direction, adding algebraically the potential differ-
potential
ences that we encounter. Then when we return to our starting point, we must 
i
also have returned to our starting potential. Before actually doing so, we shall 
Figure 27-3 A single-loop circuit in which 
formalize this idea in a statement that holds not only for single-loop circuits such 
a resistance R is connected across an ideal 
as that of Fig. 27-3 but also for any complete loop in a multiloop circuit, as we 
 battery B with emf ℰ. The resulting cur-
rent i is the same throughout the circuit. shall discuss in Module 27-2:
776 CHAPTER 27 CIRCUITS
Other Single-Loop Circuits
Next we extend the simple circuit of Fig. 27-3 in two ways.
Internal Resistance
Figure 27-4a shows a real battery, with internal resistance r, wired to an external 
resistor of resistance R. The internal resistance of the battery is the electrical 
 resistance of the conducting materials of the battery and thus is an unremovable 
feature of the battery. In Fig. 27-4a, however, the battery is drawn as if it could 
be separated into an ideal battery with emf ℰ and a resistor of resistance r. The 
order in which the symbols for these separated parts are drawn does not matter.
i
i
ab a
+
b
r
R
V
ir b
r
i
R
i
iR
V V
a a
a
– 
Emf device Resistor
Real battery
i
(a) (b)
Figure 27-4 (a) A single-loop circuit containing a real battery having internal resistance 
r and emf ℰ. (b) The same circuit, now spread out in a line. The potentials encountered 
in traversing the circuit clockwise from a are also shown. The potential V is arbitrarily 
a
 assigned a value of zero, and other potentials in the circuit are graphed relative to V .
a
i
If we apply the loop rule clockwise beginning at point a, the changes in 
b
 potential give us
R
1
 ℰ – ir – iR = 0. (27-3)
+
i
R
2
Solving for the current, we find
–
ℰ
R
3
i =. (27-4)
 R + r
a
i
Note that this equation reduces to Eq. 27-2 if the battery is ideal — that is, if r = 0.
(a) Figure 27-4b shows graphically the changes in electric potential around the 
Series resistors 
circuit. (To better link Fig. 27-4b with the closed circuit in Fig. 27-4a, imagine 
and their
 curling the graph into a cylinder with point a at the left overlapping point a at 
equivalent have 
the right.) Note how traversing the circuit is like walking around a (potential) 
the same
mountain back to your starting point—you return to the starting  elevation.
current (“ser-i”).
In this book, when a battery is not described as real or if no internal resis-
b
tance is indicated, you can generally assume that it is ideal — but, of course, in the 
real world batteries are always real and have internal resistance.
+
i
R Resistances in Series
eq
–
Figure 27-5a shows three resistances connected in series to an ideal battery 
with emf ℰ. This description has little to do with how the resistances are drawn. 
a
Rather, “in series” means that the resistances are wired one after another and that 
(b)
a potential difference V is applied across the two ends of the series. In Fig. 27-5a, 
the resistances are connected one after another between a and b, and a  potential 
Figure 27-5 (a) Three resistors are connected 
difference is maintained across a and b by the battery. The potential differences  
in series between points a and b. (b) An 
that then exist across the resistances in the series produce identical currents i in 
equivalent circuit, with the three resistors 
 replaced with their equivalent resistance R . them. In general,
eq
Potential (V)
27-1 SINGLE-LOOP CIRCUITS 777
 When a potential difference V is applied across resistances connected in series, 
the resistances have identical currents i. The sum of the potential differences 
across the  resistances is equal to the applied potential difference V.
Note that charge moving through the series resistances can move along only a 
single route. If there are additional routes, so that the currents in different resis-
tances are different, the resistances are not connected in series.
 Resistances connected in series can be replaced with an equivalent resistance 
R that has the same current i and the same total potential difference V as the 
eq
actual  resistances.
You might remember that R and all the actual series resistances have the same 
eq
current i with the nonsense word “ser-i.” Figure 27-5b shows the equivalent resis-
tance R that can replace the three resistances of Fig. 27-5a.
eq
To derive an expression for R in Fig. 27-5b, we apply the loop rule to both 
eq
circuits. For Fig. 27-5a, starting at a and going clockwise around the circuit, we 
find
ℰ – iR – iR – iR = 0,
1 2 3
ℰ
or i = . (27-5)
R + R + R
1 2 3
For Fig. 27-5b, with the three resistances replaced with a single equivalent resis-
tance R , we find
eq
ℰ – iR = 0,
eq
ℰ
or i = . (27-6)
R
eq
Comparison of Eqs. 27-5 and 27-6 shows that
R = R + R + R .
eq 1 2 3
The extension to n resistances is straightforward and is
n
 R = ∑ R  (n resistances in series). (27-7)
eq j
j=1
Note that when resistances are in series, their equivalent resistance is greater 
than any of the individual resistances.
 Checkpoint 2
In Fig. 27-5a, if R > R > R , rank the three resistances  according to (a) the current 
The internal resistance reduces
1 2 3
through them and (b) the potential difference across them, greatest first.
the potential difference between
the terminals.
i
+
b
Potential Difference Between Two Points
r = 2.0 Ω
We often want to find the potential difference between two points in a circuit. For  
R = 4.0 Ω
example, in Fig. 27-6, what is the potential difference V – V between points a 
b a
 = 12 V
and b? To find out, let’s start at point a (at potential V ) and move through the 
a
a
– 
i
battery to point b (at potential V ) while keeping track of the potential changes 
b
we encounter. When we pass through the battery’s emf, the potential increases 
Figure 27-6 Points a and b, which are at 
by ℰ. When we pass through the battery’s internal resistance r, we move in the 
the terminals of a real battery, differ in 
 direction of the current and thus the potential decreases by ir. We are then at the 
potential.
27-2 MULTILOOP CIRCUITS 781
27-2 MULTILOOP CIRCUITS
Learning Objectives 
After reading this module, you should be able to . . .
27.17 Apply the junction rule. by finding equivalent resistors, until the current through 
27.18 Draw a schematic diagram for a battery and three the battery can be determined, and then reverse the 
 parallel resistors and distinguish it from a diagram with steps to find the currents and potential differences of 
a battery and three series resistors. the individual  resistors.
27.19 Identify that resistors in parallel have the same 27.23 If a circuit cannot be simplified by using equivalent 
potential difference, which is the same value that their  resistors, identify the several loops in the circuit, choose 
equivalent  resistor has. names and directions for the currents in the branches, 
27.20 Calculate the resistance of the equivalent resistor of set up loop equations for the various loops, and solve 
several resistors in parallel. these  simultaneous equations for the unknown currents.
27.21 Identify that the total current through parallel resistors 27.24 In a circuit with identical real batteries in series, replace 
is the sum of the currents through the individual resistors. them with a single ideal battery and a single resistor.
27.22 For a circuit with a battery and some resistors in 27.25 In a circuit with identical real batteries in parallel, replace 
parallel and some in series, simplify the circuit in steps them with a single ideal battery and a single resistor.
Key Idea 
● When resistances are in parallel, they have the same potential difference. The equivalent resistance that can replace 
a parallel combination of resistances is given by
n
1 1
 = ∑   (n resistances in parallel).
R R
eq j=1 j
Multiloop Circuits
Figure 27-9 shows a circuit containing more than one loop. For simplicity, we 
 assume the batteries are ideal. There are two junctions in this circuit, at b and d, 
and there are three branches connecting these junctions. The branches are the 
left branch (bad), the right branch (bcd), and the central branch (bd). What are 
the currents in the three branches?
We arbitrarily label the currents, using a different subscript for each branch. 
Current i has the same value everywhere in branch bad, i has the same value 
1 2
everywhere in branch bcd, and i is the current through branch bd. The directions 
3
of the currents are assumed arbitrarily.
Consider junction d for a moment: Charge comes into that junction via 
 incoming currents i and i , and it leaves via outgoing current i . Because there is 
1 3 2
The current into the junction
no variation in the charge at the junction, the total incoming current must equal 
must equal the current out
the total outgoing current:
(charge is conserved).
 i + i = i. (27-18)
1 3 2
12
You can easily check that applying this condition to junction b leads to exactly a bc
+– –+
the same equation. Equation 27-18 thus suggests a general principle:
 i R R i R i
1 1 3 3 2 2
 JUNCTION RULE: The sum of the currents entering any junction must be 
equal to the sum of the currents leaving that junction.
d
Figure 27-9 A multiloop circuit consisting 
This rule is often called Kirchhoff’s junction rule (or Kirchhoff’s current law). It 
of three branches: left-hand branch bad, 
is simply a statement of the conservation of charge for a steady flow of charge—
right-hand branch bcd, and central branch 
there is neither a buildup nor a depletion of charge at a junction. Thus, our basic 
bd. The circuit also consists of three loops: 
tools for solving complex circuits are the loop rule (based on the conservation of 
left-hand loop badb, right-hand loop bcdb, 
energy) and the junction rule (based on the conservation of charge). and big loop badcb.
27-2 MULTILOOP CIRCUITS 781
27-2 MULTILOOP CIRCUITS
Learning Objectives 
After reading this module, you should be able to . . .
27.17 Apply the junction rule. by finding equivalent resistors, until the current through 
27.18 Draw a schematic diagram for a battery and three the battery can be determined, and then reverse the 
 parallel resistors and distinguish it from a diagram with steps to find the currents and potential differences of 
a battery and three series resistors. the individual  resistors.
27.19 Identify that resistors in parallel have the same 27.23 If a circuit cannot be simplified by using equivalent 
potential difference, which is the same value that their  resistors, identify the several loops in the circuit, choose 
equivalent  resistor has. names and directions for the currents in the branches, 
27.20 Calculate the resistance of the equivalent resistor of set up loop equations for the various loops, and solve 
several resistors in parallel. these  simultaneous equations for the unknown currents.
27.21 Identify that the total current through parallel resistors 27.24 In a circuit with identical real batteries in series, replace 
is the sum of the currents through the individual resistors. them with a single ideal battery and a single resistor.
27.22 For a circuit with a battery and some resistors in 27.25 In a circuit with identical real batteries in parallel, replace 
parallel and some in series, simplify the circuit in steps them with a single ideal battery and a single resistor.
Key Idea 
● When resistances are in parallel, they have the same potential difference. The equivalent resistance that can replace 
a parallel combination of resistances is given by
n
1 1
 = ∑   (n resistances in parallel).
R R
eq j=1 j
Multiloop Circuits
Figure 27-9 shows a circuit containing more than one loop. For simplicity, we 
 assume the batteries are ideal. There are two junctions in this circuit, at b and d, 
and there are three branches connecting these junctions. The branches are the 
left branch (bad), the right branch (bcd), and the central branch (bd). What are 
the currents in the three branches?
We arbitrarily label the currents, using a different subscript for each branch. 
Current i has the same value everywhere in branch bad, i has the same value 
1 2
everywhere in branch bcd, and i is the current through branch bd. The directions 
3
of the currents are assumed arbitrarily.
Consider junction d for a moment: Charge comes into that junction via 
 incoming currents i and i , and it leaves via outgoing current i . Because there is 
1 3 2
The current into the junction
no variation in the charge at the junction, the total incoming current must equal 
must equal the current out
the total outgoing current:
(charge is conserved).
 i + i = i. (27-18)
1 3 2
12
You can easily check that applying this condition to junction b leads to exactly a bc
+– –+
the same equation. Equation 27-18 thus suggests a general principle:
 i R R i R i
1 1 3 3 2 2
 JUNCTION RULE: The sum of the currents entering any junction must be 
equal to the sum of the currents leaving that junction.
d
Figure 27-9 A multiloop circuit consisting 
This rule is often called Kirchhoff’s junction rule (or Kirchhoff’s current law). It 
of three branches: left-hand branch bad, 
is simply a statement of the conservation of charge for a steady flow of charge—
right-hand branch bcd, and central branch 
there is neither a buildup nor a depletion of charge at a junction. Thus, our basic 
bd. The circuit also consists of three loops: 
tools for solving complex circuits are the loop rule (based on the conservation of 
left-hand loop badb, right-hand loop bcdb, 
energy) and the junction rule (based on the conservation of charge). and big loop badcb.
788 CHAPTER 27 CIRCUITS
27-3 THE AMMETER AND THE VOLTMETER
Learning Objective 
After reading this module, you should be able to . . .
27.26 Explain the use of an ammeter and a voltmeter, including the resistance required of each in order not to 
affect the measured quantities.
Key Idea 
● Here are three measurement instruments used with measures voltage (potential differences). A multimeter can 
circuits: An ammeter measures current. A voltmeter be used to measure current, voltage, or resistance.
i
The Ammeter and the Voltmeter
+
An instrument used to measure currents is called an ammeter. To measure the 
–
R
current in a wire, you usually have to break or cut the wire and insert the amme-
2
ter so that the current to be measured passes through the meter. (In Fig. 27-14, 
r
c ammeter A is set up to measure current i.) It is essential that the resistance R of 
A
the ammeter be very much smaller than other resistances in the circuit. Otherwise, 
a
the very presence of the meter will change the current to be measured.
A
R V
1
A meter used to measure potential differences is called a voltmeter. To find 
b
the potential difference between any two points in the circuit, the voltmeter ter-
minals are connected between those points without breaking or cutting the wire. 
i
d
(In Fig. 27-14, voltmeter V is set up to measure the voltage across R .) It is essen-
1
tial that the resistance R of a voltmeter be very much larger than the resistance 
Figure 27-14 A single-loop circuit, showing 
V
how to connect an ammeter (A) and a of any circuit element across which the voltmeter is connected. Otherwise, the 
 voltmeter (V). meter alters the potential difference that is to be measured.
Often a single meter is packaged so that, by means of a switch, it can be made 
to serve as either an ammeter or a voltmeter—and usually also as an ohmmeter, 
designed to measure the resistance of any element connected between its termi-
nals. Such a versatile unit is called a multimeter.
27-4 RC CIRCUITS
Learning Objectives 
After reading this module, you should be able to . . .
27.27 Draw schematic diagrams of charging and dis- 27.31 From the function giving the charge as a function 
charging RC circuits. of time in a charging or discharging RC circuit, find the 
capacitor’s potential difference as a function of time.
27.28 Write the loop equation (a differential equation) for a 
charging RC circuit. 27.32 In a charging or discharging RC circuit, find the resis-
tor’s current and potential difference as functions of time.
27.29 Write the loop equation (a differential equation) for a 
discharging RC circuit. 27.33 Calculate the capacitive time constant τ.
27.30 For a capacitor in a charging or discharging RC circuit, 27.34 For a charging RC circuit and a discharging RC circuit, 
apply the relationship giving the charge as a function of time. determine the capacitor’s charge and potential difference 
at the start of the process and then a long time later.
Key Ideas 
● When an emf ℰ is applied to a resistance R and capacitance ● When a capacitor discharges through a resistance R, 
C in series, the charge on the capacitor increases  according to the charge on the capacitor decays according to
–t/RC
–t/RC
q = C ℰ(1 – e )  (charging a capacitor),
q = q e  (discharging a capacitor).
0
in which C ℰ = q is the equilibrium (final) charge and 
0
● During the discharging, the current is
RC = τ is the capacitive time constant of the circuit. 
dq q
● During the charging, the current is 0
−t/RC
i = = − e  (discharging a capacitor).
( )
dt RC
dq ℰ
−t/RC
i = = e  (charging a capacitor).
( )
dt R
788 CHAPTER 27 CIRCUITS
27-3 THE AMMETER AND THE VOLTMETER
Learning Objective 
After reading this module, you should be able to . . .
27.26 Explain the use of an ammeter and a voltmeter, including the resistance required of each in order not to 
affect the measured quantities.
Key Idea 
● Here are three measurement instruments used with measures voltage (potential differences). A multimeter can 
circuits: An ammeter measures current. A voltmeter be used to measure current, voltage, or resistance.
i
The Ammeter and the Voltmeter
+
An instrument used to measure currents is called an ammeter. To measure the 
–
R
current in a wire, you usually have to break or cut the wire and insert the amme-
2
ter so that the current to be measured passes through the meter. (In Fig. 27-14, 
r
c ammeter A is set up to measure current i.) It is essential that the resistance R of 
A
the ammeter be very much smaller than other resistances in the circuit. Otherwise, 
a
the very presence of the meter will change the current to be measured.
A
R V
1
A meter used to measure potential differences is called a voltmeter. To find 
b
the potential difference between any two points in the circuit, the voltmeter ter-
minals are connected between those points without breaking or cutting the wire. 
i
d
(In Fig. 27-14, voltmeter V is set up to measure the voltage across R .) It is essen-
1
tial that the resistance R of a voltmeter be very much larger than the resistance 
Figure 27-14 A single-loop circuit, showing 
V
how to connect an ammeter (A) and a of any circuit element across which the voltmeter is connected. Otherwise, the 
 voltmeter (V). meter alters the potential difference that is to be measured.
Often a single meter is packaged so that, by means of a switch, it can be made 
to serve as either an ammeter or a voltmeter—and usually also as an ohmmeter, 
designed to measure the resistance of any element connected between its termi-
nals. Such a versatile unit is called a multimeter.
27-4 RC CIRCUITS
Learning Objectives 
After reading this module, you should be able to . . .
27.27 Draw schematic diagrams of charging and dis- 27.31 From the function giving the charge as a function 
charging RC circuits. of time in a charging or discharging RC circuit, find the 
capacitor’s potential difference as a function of time.
27.28 Write the loop equation (a differential equation) for a 
charging RC circuit. 27.32 In a charging or discharging RC circuit, find the resis-
tor’s current and potential difference as functions of time.
27.29 Write the loop equation (a differential equation) for a 
discharging RC circuit. 27.33 Calculate the capacitive time constant τ.
27.30 For a capacitor in a charging or discharging RC circuit, 27.34 For a charging RC circuit and a discharging RC circuit, 
apply the relationship giving the charge as a function of time. determine the capacitor’s charge and potential difference 
at the start of the process and then a long time later.
Key Ideas 
● When an emf ℰ is applied to a resistance R and capacitance ● When a capacitor discharges through a resistance R, 
C in series, the charge on the capacitor increases  according to the charge on the capacitor decays according to
–t/RC
–t/RC
q = C ℰ(1 – e )  (charging a capacitor),
q = q e  (discharging a capacitor).
0
in which C ℰ = q is the equilibrium (final) charge and 
0
● During the discharging, the current is
RC = τ is the capacitive time constant of the circuit. 
dq q
● During the charging, the current is 0
−t/RC
i = = − e  (discharging a capacitor).
( )
dt RC
dq ℰ
−t/RC
i = = e  (charging a capacitor).
( )
dt R
788 CHAPTER 27 CIRCUITS
27-3 THE AMMETER AND THE VOLTMETER
Learning Objective 
After reading this module, you should be able to . . .
27.26 Explain the use of an ammeter and a voltmeter, including the resistance required of each in order not to 
affect the measured quantities.
Key Idea 
● Here are three measurement instruments used with measures voltage (potential differences). A multimeter can 
circuits: An ammeter measures current. A voltmeter be used to measure current, voltage, or resistance.
i
The Ammeter and the Voltmeter
+
An instrument used to measure currents is called an ammeter. To measure the 
–
R
current in a wire, you usually have to break or cut the wire and insert the amme-
2
ter so that the current to be measured passes through the meter. (In Fig. 27-14, 
r
c ammeter A is set up to measure current i.) It is essential that the resistance R of 
A
the ammeter be very much smaller than other resistances in the circuit. Otherwise, 
a
the very presence of the meter will change the current to be measured.
A
R V
1
A meter used to measure potential differences is called a voltmeter. To find 
b
the potential difference between any two points in the circuit, the voltmeter ter-
minals are connected between those points without breaking or cutting the wire. 
i
d
(In Fig. 27-14, voltmeter V is set up to measure the voltage across R .) It is essen-
1
tial that the resistance R of a voltmeter be very much larger than the resistance 
Figure 27-14 A single-loop circuit, showing 
V
how to connect an ammeter (A) and a of any circuit element across which the voltmeter is connected. Otherwise, the 
 voltmeter (V). meter alters the potential difference that is to be measured.
Often a single meter is packaged so that, by means of a switch, it can be made 
to serve as either an ammeter or a voltmeter—and usually also as an ohmmeter, 
designed to measure the resistance of any element connected between its termi-
nals. Such a versatile unit is called a multimeter.
27-4 RC CIRCUITS
Learning Objectives 
After reading this module, you should be able to . . .
27.27 Draw schematic diagrams of charging and dis- 27.31 From the function giving the charge as a function 
charging RC circuits. of time in a charging or discharging RC circuit, find the 
capacitor’s potential difference as a function of time.
27.28 Write the loop equation (a differential equation) for a 
charging RC circuit. 27.32 In a charging or discharging RC circuit, find the resis-
tor’s current and potential difference as functions of time.
27.29 Write the loop equation (a differential equation) for a 
discharging RC circuit. 27.33 Calculate the capacitive time constant τ.
27.30 For a capacitor in a charging or discharging RC circuit, 27.34 For a charging RC circuit and a discharging RC circuit, 
apply the relationship giving the charge as a function of time. determine the capacitor’s charge and potential difference 
at the start of the process and then a long time later.
Key Ideas 
● When an emf ℰ is applied to a resistance R and capacitance ● When a capacitor discharges through a resistance R, 
C in series, the charge on the capacitor increases  according to the charge on the capacitor decays according to
–t/RC
–t/RC
q = C ℰ(1 – e )  (charging a capacitor),
q = q e  (discharging a capacitor).
0
in which C ℰ = q is the equilibrium (final) charge and 
0
● During the discharging, the current is
RC = τ is the capacitive time constant of the circuit. 
dq q
● During the charging, the current is 0
−t/RC
i = = − e  (discharging a capacitor).
( )
dt RC
dq ℰ
−t/RC
i = = e  (charging a capacitor).
( )
dt R
27-4 RC CIRCUITS 789
a
S
RC Circuits
b
R
In preceding modules we dealt only with circuits in which the currents did not 
+
vary with time. Here we begin a discussion of time-varying currents.
C
–
Charging a Capacitor
The capacitor of capacitance C in Fig. 27-15 is initially uncharged. To charge it, 
Figure 27-15 When switch S is closed 
we close switch S on point a. This completes an RC series circuit consisting of the 
on a, the capacitor is charged through 
 capacitor, an ideal battery of emf ℰ, and a resistance R.
the  resistor. When the switch is afterward 
From Module 25-1, we already know that as soon as the circuit is complete, 
closed on b, the capacitor discharges 
charge begins to flow (current exists) between a capacitor plate and a battery 
through the resistor.
 terminal on each side of the capacitor. This current increases the charge q on the 
plates and the potential difference V (= q/C) across the  capacitor. When that 
C
potential difference equals the potential difference across the battery (which here 
is equal to the emf ℰ), the current is zero. From Eq. 25-1 (q = CV), the equilib-
rium (final) charge on the then fully charged capacitor is equal to C ℰ.
Here we want to examine the charging process. In particular we want to 
know how the charge q(t) on the capacitor plates, the potential difference V (t) 
C
across the capacitor, and the current i(t) in the circuit vary with time during the 
charging process. We begin by applying the loop rule to the circuit, traversing it 
clockwise from the negative terminal of the battery. We find
q
 ℰ − iR − = 0. (27-30)
C
The last term on the left side represents the potential difference across the capac-
itor. The term is negative because the capacitor’s top plate, which is connected to 
the battery’s positive terminal, is at a higher potential than the lower plate. Thus, 
there is a drop in potential as we move down through the capacitor.
We cannot immediately solve Eq. 27-30 because it contains two variables, 
The capacitor’s charge
i and q. However, those variables are not independent but are related by
grows as the resistor’s
dq
current dies out.
i = . (27-31)
 dt
Substituting this for i in Eq. 27-30 and rearranging, we find
12
C
8
dq q
R + = ℰ (charging equation). (27-32)
 dt C
4
This differential equation describes the time variation of the charge q on the 
246 810
0
 capacitor in Fig. 27-15. To solve it, we need to find the function q(t) that satis-
Time (ms)
fies this equation and also satisfies the condition that the capacitor be initially 
(a)
 uncharged; that is, q = 0 at t = 0.
We shall soon show that the solution to Eq. 27-32 is
6
/R
–t/RC
 q = C ℰ(1 – e )  (charging a capacitor). (27-33)
4
2
(Here e is the exponential base, 2.718 . . . , and not the elementary charge.) 
0
Note that Eq. 27-33 does indeed satisfy our required initial condition, because 
246 8 10
–t/RC
at t = 0 the term e is unity; so the equation gives q = 0. Note also that as 
Time (ms)
–t/RC
t goes to infinity (that is, a long time later), the term  e goes to zero; so 
(b)
the equation gives the proper value for the full (equilibrium) charge on the 
Figure 27-16 (a) A plot of Eq. 27-33, which 
 capacitor — namely, q = C ℰ. A plot of q(t) for the charging process is given in 
shows the buildup of charge on the capaci-
Fig. 27-16a.
tor of Fig. 27-15. (b) A plot of Eq. 27-34, 
The derivative of q(t) is the current i(t) charging the capacitor:
which shows the decline of the charging 
current in the circuit of Fig. 27-15. The 
curves are plotted for R = 2000 Ω, C = 1 μF, 
dq ℰ
−t/RC
 i = = e  (charging a capacitor). (27-34)
and ℰ = 10 V; the small triangles  represent 
( )
dt R
successive intervals of one time constant τ.
i (mA) q (  C)μ
QUESTIONS 793
Review & Summary
Emf  An emf device does work on charges to maintain a  potential where V is the potential across the terminals of the battery. The rate 
difference between its output terminals. If dW is the work the device P at which energy is dissipated as thermal energy in the battery is
r
does to force positive charge dq from the negative to the positive ter-
2
 P = i r. (27-16)
r
minal, then the emf (work per unit charge) of the  device is
The rate P at which the chemical energy in the battery changes is
emf
dW
 ℰ =  (definition of ℰ). (27-1)
 P = iℰ. (27-17)
dq emf
The volt is the SI unit of emf as well as of potential difference. An 
Series Resistances  When resistances are in series, they have 
ideal emf device is one that lacks any internal resistance. The potential  
the same current. The equivalent resistance that can replace a  
difference between its terminals is equal to the emf. A real emf device 
series combination of resistances is
has internal resistance. The potential difference  between its terminals 
n
is equal to the emf only if there is no current through the device.
 R = ∑ R  (n resistances in series). (27-7)
eq j
j=1
Analyzing Circuits  The change in potential in traversing a 
Parallel Resistances  When resistances are in parallel, 
 resistance R in the direction of the current is –iR; in the  opposite 
they have the same potential difference. The equivalent resistance 
direction it is +iR (resistance rule). The change in potential in tra-
that can replace a parallel combination of resistances is given by
versing an ideal emf  device in the direction of the emf arrow is +ℰ; 
n
in the opposite direction it is –ℰ (emf rule). Conservation of  energy 
1 1
  = ∑   (n resistances in parallel). (27-24)
leads to the loop rule:
R R
eq j=1 j
Loop Rule.  The algebraic sum of the changes in potential  encountered 
RC Circuits  When an emf ℰ is applied to a resistance R 
in a complete traversal of any loop of a circuit must be zero.
and capacitance C in series, as in Fig. 27-15 with the switch at a, the 
charge on the capacitor increases according to
Conservation of charge gives us the junction rule:
–t/RC
 q = C ℰ(1 – e )  (charging a capacitor), (27-33)
Junction Rule.  The sum of the currents entering any junction must 
be equal to the sum of the currents leaving that junction.
in which Cℰ = q is the equilibrium (final) charge and RC = τ is the 
0
capacitive time constant of the circuit. During the charging, the current is
Single-Loop Circuits  The current in a single-loop circuit con-
taining a single resistance R and an emf device with emf ℰ and 
dq ℰ
−t/RC
 i = = e  (charging a capacitor). (27-34)
internal resistance r is
( )
dt R
ℰ
When a capacitor discharges through a resistance R, the charge on 
 i = , (27-4)
R + r
the capacitor decays according to
which reduces to i = ℰ/R for an ideal emf device with r = 0.
–t/RC
 q = q e  (discharging a capacitor). (27-39)
0
Power  When a real battery of emf ℰ and internal resistance r 
During the discharging, the current is
does work on the charge carriers in a current i through the battery, 
the rate P of energy transfer to the charge carriers is
dq q
0
−t/RC
 i = = − e  (discharging a capacitor). (27-40)
( )
 P = iV, (27-14) dt RC
Questions
1  (a) In Fig. 27-18a, with R > R , is the potential difference across R more than, less than, or equal to that across R ? (b) Is the 
1 2 2 1
current through resistor R more than, less than, or equal to that 
2
R
3
through resistor R ?
1
 and R in series? (b) Are  
2  (a) In Fig. 27-18a, are resistors R
1 3
R R
1 2
resistors R and R in parallel? (c) Rank the equivalent resistances 
1 2
+
–
R
R
1
2 of the four circuits shown in Fig. 27-18, greatest first.
–
+
R
3
 and R , with R > R , to a bat-
3  You are to connect resistors R
1 2 1 2
(a) (b)
tery, first individually, then in series, and then in parallel. Rank 
those arrangements according to the amount of current through the 
R
1
battery, greatest first.
–
R 4  In Fig. 27-19, a circuit consists 
3
+
+–
of a battery and two uniform resis-
R
R
2
1
+ tors, and the section lying along an 
R R
1 2
R
3
– x axis is divided into five segments x
(c) (d)
of equal lengths. (a) Assume that 
ab cd e
R
2
R = R and rank the segments 
1 2
Figure 27-18 Questions 1 and 2. according to the magnitude of the Figure 27-19 Question 4.
QUESTIONS 793
Review & Summary
Emf  An emf device does work on charges to maintain a  potential where V is the potential across the terminals of the battery. The rate 
difference between its output terminals. If dW is the work the device P at which energy is dissipated as thermal energy in the battery is
r
does to force positive charge dq from the negative to the positive ter-
2
 P = i r. (27-16)
r
minal, then the emf (work per unit charge) of the  device is
The rate P at which the chemical energy in the battery changes is
emf
dW
 ℰ =  (definition of ℰ). (27-1)
 P = iℰ. (27-17)
dq emf
The volt is the SI unit of emf as well as of potential difference. An 
Series Resistances  When resistances are in series, they have 
ideal emf device is one that lacks any internal resistance. The potential  
the same current. The equivalent resistance that can replace a  
difference between its terminals is equal to the emf. A real emf device 
series combination of resistances is
has internal resistance. The potential difference  between its terminals 
n
is equal to the emf only if there is no current through the device.
 R = ∑ R  (n resistances in series). (27-7)
eq j
j=1
Analyzing Circuits  The change in potential in traversing a 
Parallel Resistances  When resistances are in parallel, 
 resistance R in the direction of the current is –iR; in the  opposite 
they have the same potential difference. The equivalent resistance 
direction it is +iR (resistance rule). The change in potential in tra-
that can replace a parallel combination of resistances is given by
versing an ideal emf  device in the direction of the emf arrow is +ℰ; 
n
in the opposite direction it is –ℰ (emf rule). Conservation of  energy 
1 1
  = ∑   (n resistances in parallel). (27-24)
leads to the loop rule:
R R
eq j=1 j
Loop Rule.  The algebraic sum of the changes in potential  encountered 
RC Circuits  When an emf ℰ is applied to a resistance R 
in a complete traversal of any loop of a circuit must be zero.
and capacitance C in series, as in Fig. 27-15 with the switch at a, the 
charge on the capacitor increases according to
Conservation of charge gives us the junction rule:
–t/RC
 q = C ℰ(1 – e )  (charging a capacitor), (27-33)
Junction Rule.  The sum of the currents entering any junction must 
be equal to the sum of the currents leaving that junction.
in which Cℰ = q is the equilibrium (final) charge and RC = τ is the 
0
capacitive time constant of the circuit. During the charging, the current is
Single-Loop Circuits  The current in a single-loop circuit con-
taining a single resistance R and an emf device with emf ℰ and 
dq ℰ
−t/RC
 i = = e  (charging a capacitor). (27-34)
internal resistance r is
( )
dt R
ℰ
When a capacitor discharges through a resistance R, the charge on 
 i = , (27-4)
R + r
the capacitor decays according to
which reduces to i = ℰ/R for an ideal emf device with r = 0.
–t/RC
 q = q e  (discharging a capacitor). (27-39)
0
Power  When a real battery of emf ℰ and internal resistance r 
During the discharging, the current is
does work on the charge carriers in a current i through the battery, 
the rate P of energy transfer to the charge carriers is
dq q
0
−t/RC
 i = = − e  (discharging a capacitor). (27-40)
( )
 P = iV, (27-14) dt RC
Questions
1  (a) In Fig. 27-18a, with R > R , is the potential difference across R more than, less than, or equal to that across R ? (b) Is the 
1 2 2 1
current through resistor R more than, less than, or equal to that 
2
R
3
through resistor R ?
1
 and R in series? (b) Are  
2  (a) In Fig. 27-18a, are resistors R
1 3
R R
1 2
resistors R and R in parallel? (c) Rank the equivalent resistances 
1 2
+
–
R
R
1
2 of the four circuits shown in Fig. 27-18, greatest first.
–
+
R
3
 and R , with R > R , to a bat-
3  You are to connect resistors R
1 2 1 2
(a) (b)
tery, first individually, then in series, and then in parallel. Rank 
those arrangements according to the amount of current through the 
R
1
battery, greatest first.
–
R 4  In Fig. 27-19, a circuit consists 
3
+
+–
of a battery and two uniform resis-
R
R
2
1
+ tors, and the section lying along an 
R R
1 2
R
3
– x axis is divided into five segments x
(c) (d)
of equal lengths. (a) Assume that 
ab cd e
R
2
R = R and rank the segments 
1 2
Figure 27-18 Questions 1 and 2. according to the magnitude of the Figure 27-19 Question 4.
PROBLEMS 795
Problems
          Tutoring problem available (at instructor’s discretion) in WileyPLUS and WebAssign
SSM    Worked-out solution available in Student Solutions Manual
WWW  Worked-out solution is at
http://www.wiley.com/college/halliday
   
– Number of dots indicates level of problem difficulty
•  •••   ILW    Interactive solution is at 
 Additional information available in The Flying Circus of Physics and at flyingcircusofphysics.com
Module 27-1  Single-Loop Circuits •6  A standard flashlight battery can deliver about 2.0 W · h of 
R
SSM WWW energy before it runs down. (a) If a battery costs US$0.80, what 
•1  In Fig. 27-25, the 1
 
is the cost of operating a 100 W lamp for 8.0 h using  batteries? 
ideal batteries have emfs ℰ = 12 V and 
1 +
R
2
2
(b) What is the cost if energy is provided at the rate of US$0.06 per 
ℰ = 6.0  V. What are (a) the current, 
2 –
  
kilowatt-hour?
the dissipation rate in (b)  resistor  1  1
(4.0  Ω) and (c) resistor 2 (8.0 Ω), and 
•7  A wire of resistance 5.0 Ω is connected to a battery whose emf 
– +
the energy transfer rate in (d) battery 1 
ℰ is 2.0 V and whose internal resistance is 1.0 Ω. In 2.0 min, how 
and (e) battery 2? Is energy being sup- Figure 27-25  
much energy is (a) transferred from chemical form in the battery, 
plied or  absorbed by (f) battery 1 and Problem 1.
(b) dissipated as thermal energy in the wire, and (c) dissipated as 
(g) battery 2?
thermal energy in the battery?
•2  In Fig. 27-26, the ideal batteries  
Q
•8  A certain car battery with a 12.0 V emf has an initial charge 
have emfs ℰ = 150 V and ℰ = 50 V 
1 2 R
1
of 120 A · h. Assuming that the potential across the terminals stays  
and the resistances are R = 3.0 Ω and 
1
– – constant until the battery is completely discharged, for how many 
R = 2.0 Ω. If the potential at P is 100 V,     
2
1 2
+ +
hours can it deliver energy at the rate of 100 W?
what is it at Q?
R
•9  (a) In electron-volts, how much work does an ideal battery 
2
ILW
•3 A car battery with a 12 V emf 
 
P
with a 12.0 V emf do on an electron that passes through the bat-
and an internal resistance of 0.040 Ω is 
18
tery from the positive to the negative terminal? (b) If 3.40 × 10
Figure 27-26 Problem 2. 
being charged with a current of 50 A. 
electrons pass through each second, what is the power of the bat-
What are (a) the potential difference V across the terminals, (b) the 
tery in watts?
rate P of energy dissipation inside the battery, and (c) the rate P 
r emf
••10  (a) In Fig. 27-28, what 
of energy conversion to chemical form? When the battery is used 
+ +
value must R have if the current in 
to supply 50 A to the starter motor, what are (d) V and (e) P ?
r
  
1  
2
– –
the  circuit is to be 1.0 mA? Take 
•4 Figure 27-27 shows a circuit of four resistors that are con -
 
ℰ = 2.0 V, ℰ = 3.0 V, and r = r = 
1 2 1 2
nected to a larger circuit. The graph below the circuit shows the r r
1 2
3.0 Ω. (b) What is the rate at which 
electric potential V(x) as a function of position x along the lower 
thermal energy appears in R?
branch of the circuit, through resistor 4; the potential V is 12.0 V. R
A
The graph above the circuit shows the electric  potential V(x)  versus ••11 SSM In Fig. 27-29, circuit 
 
position x along the upper branch of the circuit, through  resistors section AB absorbs energy at a 
Figure 27-28 Problem 10.
1, 2, and 3; the potential differences are ΔV = 2.00 V and ΔV = rate of 50 W when current i = 1.0 A 
B C
5.00 V. Resistor 3 has a resistance of 200 Ω. What is the  resistance through it is in the indicated i
of (a) resistor 1 and (b) resistor 2? direction. Resistance R = 2.0 Ω. 
X
AB
(a) What is the potential difference  
R
V between A and B? Emf device X 
Figure 27-29 Problem 11.
ΔV
B
lacks internal  resistance. (b) What 
ΔV
C
is its emf? (c) Is point B connected 
to the positive terminal of X or to the negative terminal?
0 x
••12  Figure 27-30 shows a resistor of resis-
Wire 1
tance R = 6.00 Ω connected to an ideal bat-
tery of emf ℰ = 12.0 V by means of two 
copper wires. Each wire has length 20.0 cm 
R
12 3
and radius 1.00 mm. In dealing with such cir-
cuits in this chapter, we generally neglect the  
4
potential  differences along the wires and the 
Wire 2
transfer of energy to thermal energy in them. 
Figure 27-30  
Check the validity of this neglect for the cir-
Problem 12.
V
A
cuit of Fig. 27-30: What is the potential dif-
ference across (a) the resistor and (b) each of the two sections 
Figure 27-27  
of wire? At what rate is energy lost to thermal energy in (c) the 
x
Problem 4. 0
resistor and (d) each section of wire?
••13  A 10-km-long underground cable extends east to west and 
•5  A 5.0 A current is set up in a circuit for 6.0 min by a recharge-
consists of two parallel wires, each of which has resistance 13 Ω/km. 
able battery with a 6.0 V emf. By how much is the chemical energy 
An electrical short develops at distance x from the west end when 
of the battery reduced?
V (V)
";


//var _service = OpenAiService.Instance.AddOpenAi(settings =>
//{
//    settings.ApiKey = Environment.GetEnvironmentVariable("AzureApiKey") ?? throw new Exception("Azure api key is null");
//    settings.Azure.ResourceName = "canadaeastalibdeir";
//    settings.Azure.MapDeploymentChatModel("alibdeiropenai", ChatModelType.Gpt4_32K);
//    settings.UseVersionForChat("")
//});

QuizOpenAiService service = new(OpenAiService.Factory);
await service.GetQuizzes(text);