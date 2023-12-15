-- Create Database
CREATE DATABASE ScienceSolver
--CREATE TABLE
--Mathematics
-- Mathematical Formula
CREATE TABLE MathematicalTheorem(
Number INTEGER IDENTITY(1,1) NOT NULL PRIMARY KEY,
Type VARCHAR(15) NOT NULL,
Name NVARCHAR(100) NOT NULL,
FORMULA NVARCHAR(MAX) NOT NULL
);

DROP TABLE MathematicalLaw
-- Mathematical Law
CREATE TABLE MathematicalLaw(
Number INTEGER IDENTITY(1,1) NOT NULL PRIMARY KEY,
Name NVARCHAR(100) NOT NULL,
Content NVARCHAR(MAX) NOT NULL,
FORMULA NVARCHAR(MAX) NOT NULL
);

--Physics
-- Physical Law

CREATE TABLE PhysicalLaw(
Number INTEGER IDENTITY(1,1) NOT NULL PRIMARY KEY,
Name NVARCHAR(100) NOT NULL, 
Content NVARCHAR(MAX) NOT NULL,
Formula NVARCHAR(MAX) NOT NULL
);

-- Physical Formula
CREATE TABLE PhysicalFormula(
Number INTEGER IDENTITY(1,1) NOT NULL PRIMARY KEY,
Name NVARCHAR(100) NOT NULL, 
Content NVARCHAR(MAX) NOT NULL,
Formula NVARCHAR(MAX) NOT NULL
);
-- Physical Constant
CREATE TABLE PhysicalConstant(
Number INTEGER IDENTITY(1,1) NOT NULL PRIMARY KEY,
Symbol VARCHAR(10) NOT NULL,
Name VARCHAR(50) NOT NULL,
VALUE VARCHAR(100) NOT NULL,
UNIT VARCHAR(20) NOT NULL
);

-- Chemistry 
-- Chemical Elements Board
CREATE TABLE ChemicalElement (
  Number INTEGER NOT NULL,
  Symbol VARCHAR(10) NOT NULL,
  Name VARCHAR(50) NOT NULL,
  AtomicMass FLOAT NOT NULL,
  Configuration VARCHAR(50) NOT NULL,
  Electronegativity FLOAT NOT NULL,
  Oxidation VARCHAR(50) NOT NULL,
  PRIMARY KEY (Number)
);
--Chemical Equations Board
CREATE TABLE ChemicalEquation(
Number INTEGER IDENTITY(1,1) NOT NULL PRIMARY KEY,
Precursors VARCHAR(50) NOT NULL,
ChemicalEquation VARCHAR(MAX) NOT NULL
);
-- Chemical Theorem
DROP TABLE ChemicalLaw
CREATE TABLE ChemicalLaw(
Number INTEGER IDENTITY(1,1) NOT NULL PRIMARY KEY,
Name NVARCHAR(MAX) NOT NULL,
Content NVARCHAR(MAX) NOT NULL,
FORMULA NVARCHAR(MAX) NOT NULL
);
-- Chemical Constant
CREATE TABLE ChemicalConstant(
Number INTEGER IDENTITY(1,1) NOT NULL PRIMARY KEY,
Symbol VARCHAR(10) NOT NULL,
Name VARCHAR(50) NOT NULL,
Value VARCHAR(100) NOT NULL,
UNIT VARCHAR(20) NOT NULL
);
--INSERT INFOR
INSERT INTO ChemicalElement 
(Number,Symbol, Name, AtomicMass, Configuration, Electronegativity, Oxidation)
VALUES 
(1,'H','Hydrogen',1.008,'1s1',2.2,'-1, 1'),
(2,'He','Helium',4.003,'1s2',0,'1'),
(3,'Li','Lithium',6.94,'1s1 2s1',0.98,'1'),
(4,'Be','Beryllium',9.04,'1s2 2s2',1.57,'2'),
(5,'B','Boron',10.81,'1s2 2s2 2p1',2.04,'3'),
(6,'C','Cacbon',12.01,'1s2 2s2 2p2',2.55,'-4,-3,-2,-1,0,1,2,3,4'),
(7,'N','Nito',14.007,'1s2 2s2 2p3',3.04,'-3,1,2,3,4,5'),
(8,'O','Oxygen',15.999,'1s2 2s2 2p4',3.44,'-2,-1,-1/2,-1/3,1,2'),
(9,'F','Fluorine',18.998,'1s2 2s2 2p5',3.98,'-1'),
(10,'Ne','Neon',20.18,'1s2 2s2 2p6',0,'0'),
(11,'Na','Sodium',22.989,'[Ne] 3s1',0.93,'1'),
(12,'Mg','Magnesium',24.305,'[Ne] 3s2',1.31,'2'),
(13,'Al','Aluminium',26.98,'[Ne] 3s2 3p1',1.61,'3'),
(14,'Si','Silicon',28.09,'[Ne]3s2 3p2',1.90,'4'),
(15,'P','Phoshorus',30.97,'[Ne]3s2 3p3',2.19,'-3,(1),(4),5'),
(16,'S','Sulfur',32.06,'[Ne]3s2 3p4',2.58,'-2,-1,(1,2),4,6'),
(17,'Cl','Chlorine',35.45,'[Ne]3s2 3p5',3.16,'-1,1,3,(4),5,7'),
(18,'Ar','Argon',39.95,'[Ne]3s2 3p6',0,'0'),
(19,'K','Potassium',39.098,'[Ar] 4s1',0.82,'1'),
(20,'Ca','Calcium',40.078,'[Ar] 4s2',1.0,'2'),
(21,'V','Vanadium',44.956,'[Ar] 4d1 ds2',1.36,'3');
--CREATE VIEW 
-- VIEW CHEMICAL
CREATE VIEW ChemicalElement_View AS
SELECT* FROM ChemicalElement;


CREATE VIEW ChemicalConstant_View AS
SELECT * FROM ChemicalConstant;

CREATE VIEW ChemicalEquation_View AS
SELECT * FROM ChemicalEquation;

CREATE VIEW ChemicalLaw_View AS
SELECT * FROM ChemicalLaw;

DROP View ChemicalLaw_View;

-- View Physical
CREATE VIEW PhysicalConstant_View AS
SELECT * FROM PhysicalConstant;


CREATE VIEW PhysicalFormula_View AS
SELECT * FROM PhysicalFormula;


CREATE VIEW PhysicalLaw_View AS
SELECT * FROM PhysicalLaw;


-- View Mathematics
CREATE VIEW MathematicalTheorem_View AS
SELECT * FROM MathematicalTheorem;



CREATE VIEW MathematicalLaw_View AS
SELECT * FROM MathematicalLaw;



-- VIEW
SELECT * FROM ChemicalElement_View
WHERE Name='Hydrogen'
--DELET FROM
DELETE FROM ChemicalElement
--DELETE
DROP TABLE PhysicalConstant
DROP TABLE PhysicalFormula
DROP TABLE PhysicalLaw
DROP TABLE MathematicalLaw

--DROP VIEW Chemical_Element_View


--Insert
INSERT INTO PhysicalFormula(Name, Content, Formula) VALUES
('Formula II New Ton', 'The combination of force vectors is equal to the product of acceleration and mass vectors', '(SUM)F=m*a'),
('Lever arm formula', 'Give me a fulcrum and I will be able to play this game', 'F1/F2=d1/d2'),
('Newton''s Third Law', 'When a force is applied to an object, that object will exert a reaction force of equal magnitude', 'F1=F2'),
('Formula for force through the east pulley', 'The force through the moving pulley will be reduced by 2 times', 'F''=F/2'),
('Formula of force through n movable pulleys', 'Force through n movable pulleys decreases by 2^n times', 'F''=F/(2^n)'),
('Formula for distance through n movable pulleys', 'Force through n movable pulleys decreases by 2^n times', 'd''=d*2^n'),
('Looseness formula', 'The displacement vector is equal to the directional product of the velocity vector multiplied by time', 'r=v*t'),
('Distance formula', 'Distance equals average speed and time', 's=v*t'),
('Velocity', 'Displacement and time differential', 'v=dr/dt'),
('Speed', 'Magnitude of velocity', 'V=|v|'),
('Acceleration from velocity', 'Acceleration is the differential of velocity with respect to time', 'a=dv/dt'),
('Uniform acceleration from speed', 'Acceleration is the rate of change of velocity', 'v(f)=v(i)+a*t'),
('Formula for distance through the east pulley', 'The force through the moving pulley will be reduced by 2 times', 'd''=2*d'),
('Acceleration from departure', 'Acceleration is the differential of velocity, velocity is the differential of displacement', 'a=d(dr/dt)/dt'),
('Uniform acceleration from distance', 'Acceleration is the rate of change in speed, speed is the rate of change in distance', 's(f)=s(i)+v(i)*t+*a*(t^2)/2'),
('Vector of velocity of object thrown obliquely at angle alpha', 'This speed is considered in two directions Ox,Oy', 'v=v(x)+v(y)'),
('Velocity vector on Ox in the slant throwing problem', 'Project vector v onto Ox', 'v(x)=v*cos(alpha)'),
('Velocity vector on Oy in the oblique throwing problem', 'Move vector v to Oy', 'v(y)=v*sin(alpha)-gt'),
('Skeet throwing process time', 'Equal to the time taken to throw it vertically upward with velocity v(y)', 't=2*v(y)/g'),
('Lorentz force', 'Equal to the directional product of two components, B(magnetic induction), v(velocity)', 'f(L)=-eBv'),
('Magnetic force', 'Equal to the directional product of two components, B(induction), current direction(I)', 'F(F)=-IBl'),
('Circuit efficiency', 'Work has product over total work', 'H=A(ci)/A(tp)'),
('External circuit capacity', '<many>', 'P=U*I=I^2*R=U^2/R'),
('Wasted power','Power generated on the transmission line, and internal resistance of the source', 'P(hp)=I^2*r'),
('Internal resistance of an electric wire', 'Product of output resistance with length above gives cross section', 'R = ρ(l/S)'),
('Jun''s theorem', 'Heat dissipation', 'Q=I^2Rt'),
('First Principle of Thermodynamics', 'It states that the change in energy inside ΔU of a closed system is equal to the amount of heat Q supplied to the system minus the amount of work A done by the system on the surrounding environment around', '<ERORR>'),
('Second Law of Thermodynamics', 'Second Law, or second principle, also known as the principle of entropy, relates to the irreversibility of a thermodynamic process and proposes the concept of entropy. This principle states that the entropy of a closed system has only two possibilities, either increased, or remained the same', '<ERORR>'),
('Newton''s First Law', 'If an object is not acted upon by any force or is acted upon by a total force of zero, an object at rest will remain at rest forever, and an object in motion will move forever', '<ERORR>'),
('Newton''s Third Law', 'When object A exerts a force on object B, then object B also exerts a force on object A in the same direction but in opposite directions', 'd(Y/X)=M(Y)/M(X)'),
('Newton''s Second Law', 'The total force on an object is equal to the object''s mass multiplied by its acceleration', '(SUM)F=a*m'),
('Ohm''s law of circuits', 'The voltage difference at both ends of the circuit is equal to CDDD multiplied by resistance', '(SUM)R*I=U'),
('Ohm''s Law for the whole circuit', 'External circuit voltage equals Electromotive force export minus Potential drop', 'U=E-I.r'),
('Hooke''s Law', 'An elastic object will have an elasticity coefficient k', 'F=-kx'),
('Law of reflection', 'When light is reflected, the reflected ray will lie in the plane containing the incident ray and the normal of the mirror at the point of incidence. The angle of reflection will be equal to the angle of incidence', 'i''=i'),
('Kirchhoff''s First Law', 'In electrical circuits, Kirchhoff''s laws are two equations to describe the relationship between current and voltage. These laws were formulated by Gustav Kirchhoff in 1845', '(SUM) I(k)=0'),
('Kirchhoff''s Second Law', 'In electrical circuits, Kirchhoff''s laws are two equations to describe the relationship between current and voltage. These laws were formulated by Gustav Kirchhoff in 1845', '(SUM) V(k)=0'),
('Culong''s Law', 'The force of attraction or repulsion between two point charges has a direction that coincides with the straight line connecting those two point charges. Has a magnitude proportional to the magnitude of the two charges and inversely proportional to the square of the distance between them', 'F=k*abs(q1*q2)/(r*r)'),
('Faraday''s Law of Induction', 'Faraday''s Law of Induction is a fundamental law in electromagnetism, stating that magnetic fields interact with an electric circuit to create electromotive force (EMF) - a phenomenon called electromagnetic induction. That is the basic operating principle of transformers, inductors, electric motors, generators and electromagnets', '(Flux)B=(integral)B(r,t).dA'),
('MaxWell Faraday Equation', 'In the case of an inductor with N turns, the formula becomes. In the case of an inductor there are N turns. formula becomes', 'V=-N*(denta)A/(denta)T'),
('Law of straight propagation of light', 'In a transparent and uniform medium, light travels in straight lines', '<ERORR>'),
('Law of refraction of light', 'The refracted ray always lies in the plane of incidence and on the other side of the normal from the incident ray. The incident plane is the plane formed by the incident ray and the normal. With 2 certain transparent environments, the ratio between sin i and sin r is a constant', 'sin(i)n(i)=sin(r)n(r).n=c/v.n21=n2/n1.n1i=n2r'),
('Law of light scattering', 'When light passes from one medium to any other medium, for example air, a glass of water, a part of the light is absorbed by particles of the previous medium. Its subsequent radiation is in a specific direction. This phenomenon is called light scattering', '<ERORR>'),
('Lorentz''s Law', 'Lorentz force', 'F=q(E+vB)'),
('Newton''s Law of Universal Gravitation', 'Every particle attracts every other particle in the universe with a force proportional to the mass product of them and is inversely proportional to the square of the distance between their centers. The publication of this theory is called "the first great unification" for it marks the union of the gravitational phenomena previously described on Earth with known astronomical behavior', 'F=G*(m1m2)/(r^2)'),
('Average formula', 'Error', '(Avg)A=(A1+A2+...+An)/n'),
('Measurement error formula', 'Error', 'Δ(A1)=|Avg(A)-A1|'),
('How to write error', 'Error', 'A=Avg(A)+/- Δ(A)'),
('Proportional error', 'ERORR', 'δA=ΔA/A.'),
('Law of conservation of mass', 'The following mass must be equal to the original', 'm(i)=mf'),
('Principle of conservation of energy', 'Energy remains constant before and after the process', 'W(i)=W(f)'),
('Law of conservation of momentum', 'Momentum will be conserved if there is no impulse', 'Σmivi=Σmfvf'),
('Nuclear energy','Nuclear energy', 'E=mc^2. (m is the particle mass). c=310^8 (m/s) is the speed of light'),
('Radiant energy','Radiant energy', 'W=hc/λ=hf. (c is the speed of light). h is the Boltzmann constant. λ is the wave of light. f is the frequency of light'),
('Pressure in the liquid','Pressure in the liquid', 'p=dgh. where d is the density of the liquid. g is the gravitational acceleration. h is the depth'),
('Law of pressure balance', 'In liquid and gas environments, the pressure at two points of equal height will be equal', 'erorr'),
('Formula II New Ton', 'The combination of force vectors is equal to the product of acceleration and mass vectors', '(SUM)F=ma'),
('Lever arm formula', 'Give me a fulcrum and I''ll be able to play this game', 'F1/F2=d1/d2'),
('Newton''s Third Law', 'When a force is applied to an object, that object will exert a reaction force of equal magnitude', 'F1=F2'),
('Formula for force through the east pulley', 'The force through the moving pulley will be reduced by 2 times', 'F''=F/2'),
('Formula of force through n movable pulleys', 'Force through n movable pulleys decreases by 2^n times', 'F''=F/(2^n)'),
('Formula for distance through n movable pulleys', 'Force through n movable pulleys decreases by 2^n times', 'd''=d2^n'),
('Looseness formula', 'The displacement vector is equal to the directional product of the velocity vector multiplied by time', 'r=vt'),
('Distance formula', 'Distance equals average speed and time', 's=vt'),
('Velocity', 'Displacement and time differential', 'v=dr/dt'),
('Speed', 'Magnitude of velocity', 'V=|v|'),
('Acceleration from velocity', 'Acceleration is the differential of velocity with respect to time', 'a=dv/dt'),
('Uniform acceleration from speed', 'Acceleration is the rate of change of velocity', 'v(f)=v(i)+at'),
('Formula for distance through the east pulley', 'The force through the moving pulley will be reduced by 2 times', 'd''=2d'),
('Acceleration from departure', 'Acceleration is the differential of velocity, velocity is the differential of displacement', 'a=d(dr/dt)/dt'),
('Uniform acceleration from distance', 'Acceleration is the rate of change in speed, speed is the rate of change in distance', 's(f)=s(i)+v(i)t+a(t^2)/2'),
('Vector of velocity of object thrown obliquely at angle alpha', 'This speed is considered in two directions Ox,Oy', 'v=v(x)+v(y)'),
('Velocity vector on Ox in the slant throwing problem', 'Project vector v onto Ox', 'v(x)=vcos(alpha)'),
('Velocity vector on Oy in the oblique throwing problem', 'Move vector v to Oy', 'v(y)=vsin(alpha)-gt'),
('Skeet throwing process time', 'Equal to the time taken to throw it vertically upward with velocity v(y)', 't=2*v(y)/g'),
('Lorentz force', 'Equal to the directional product of two components, B(magnetic induction), v(velocity)', 'f(L)=-eBv'),
('Magnetic force', 'Equal to the directional product of two components, B(induction), current direction(I)', 'F(F)=-IBl'),
('Circuit efficiency', 'Work has product over total work', 'H=A(ci)/A(tp)'),
('External circuit capacity', '<many>', 'P=U*I=I^2*R=U^2/R'),
('Wasted power','Power generated on the transmission line, and internal resistance of the source', 'P(hp)=I^2*r'),
('Internal resistance of an electric wire', 'Product of output resistance with length above gives cross section', 'R = ρ(l/S)'),
('Jun''s theorem', 'Heat dissipation', 'Q=I^2Rt'),
('First Principle of Thermodynamics', 'It states that the change in energy inside ΔU of a closed system is equal to the amount of heat Q supplied to the system minus the amount of work A done by the system on the surrounding environment around', '<ERROR>'),
('Principle II of HeatDynamics', 'Second law, or second principle. Also known as the principle of entropy, relates to the irreversibility of a thermodynamic process and proposes the concept of entropy. This principle states that the entropy of a closed system has only two possibilities. Either increased, or remained the same', '<ERROR>'),
('Newton''s First Law', 'If an object is not acted upon by any force or is acted upon by a total force of zero, an object at rest will remain at rest forever, and an object in motion will move forever', '<ERROR>'),
('Newton''s Third Law', 'When object A exerts a force on object B, then object B also exerts a force on object A in the same direction but in opposite directions', 'd(Y/X)=M(Y)/M(X)'),
('Newton''s Second Law', 'The total force on an object is equal to the object''s mass multiplied by its acceleration', '(SUM)F=a*m'),
('Ohm''s law of circuits', 'The voltage difference at both ends of the circuit is equal to CDDD multiplied by resistance', '(SUM)R*I=U'),
('Ohm''s Law for the whole circuit', 'External circuit voltage equals Electromotive force export minus Potential drop', 'U=E-I.r'),
('Hooke''s Law', 'An elastic object will have an elasticity coefficient k', 'F=-kx'),
('Law of reflection', 'When light is reflected, the reflected ray will lie in the plane containing the incident ray and the normal of the mirror at the point of incidence. The angle of reflection will be equal to the angle of incidence', 'i''=i'),
('Kirchhoff''s First Law', 'In electrical circuits, Kirchhoff''s laws are two equations to describe the relationship between current and voltage. These laws were formulated by Gustav Kirchhoff in 1845', '(SUM) I(k)=0'),
('Kirchhoff''s Second Law', 'In electrical circuits, Kirchhoff''s laws are two equations to describe the relationship between current and voltage. These laws were formulated by Gustav Kirchhoff in 1845', '(SUM) V(k)=0'),
('Culong''s Law', 'The force of attraction or repulsion between two point charges has a direction that coincides with the straight line connecting those two point charges. Has a magnitude proportional to the magnitude of the two charges and inversely proportional to the square of the distance between them', 'F=k*abs(q1*q2)/(r*r)'),
('Faraday''s Law of Induction', 'Faraday''s Law of Induction is a fundamental law in electromagnetism, stating that magnetic fields interact with an electric circuit to create electromotive force (EMF) - a phenomenon called electromagnetic induction. That is the basic operating principle of transformers, inductors, electric motors, generators and electromagnets', '(Flux)B=(integral)B(r,t).dA'),
('Maxwell Faraday Equation', 'In the case of an inductor with N turns, the formula becomes. In the case of an inductor there are N turns. Formula becomes', 'V=-N*(denta)A/(denta)T'),
('Law of straight propagation of light', 'Law of straight propagation of light. In a transparent and uniform medium, light travels in straight lines', '<ERROR>'),
('Law of refraction of light', 'Law of refraction of light is explained as follows. The refracted ray always lies in the plane of incidence and on the other side of the normal from the incident ray. The incident plane is the plane formed by the incident ray and the normal. With 2 certain transparent environments. The ratio between sin i and sin r is a constant', 'sin(i)*n(i)=sin(r)*n(r).n=c/v.n21=n2/n1.n1i=n2r'),
('Law of light scattering', 'When light passes from one medium to any other medium, for example air, a glass of water, a part of the light is absorbed by particles of the previous medium. Its subsequent radiation is in a specific direction. This phenomenon is called light scattering', '<ERROR>'),
('Lorentz''s Law', 'Lorentz force', 'F=q*(E+v*B)');

INSERT INTO PhysicalLaw(Name, Content, Formula) VALUES
('Lorentz force','equal to the directional product of two components, B(magnetic induction), v(velocity)','f(L)=-eBv'),
('Magnetic force', 'equal to the directional product of two components, B(induction), current direction(I)', 'F(F)=-IBl'),
('Circuit efficiency', 'Work has product over total work', 'H=A(ci)/A(tp)'),
('External circuit power', '<many ways>', 'P=U*I=I^2*R=U^2/R'),
('Wasted power','power generated on the transmission line, and internal resistance of the source', 'P(hp)=I^2*r'),
('Internal resistance of an electric wire', 'product of output resistance with length above gives cross section', 'R = ρ(l/S)'),
('Jun''s theorem', 'heat dissipation', 'Q=I^2Rt'),
('First Principle of Thermodynamics', 'It states that the change in energy.inside ΔU of a closed system is equal to the amount of heat Q supplied to the system.minus the amount of work A done by the system on the surrounding environment around', '<ERORR>'),
('Second Law of Thermodynamics', 'Second Law, or second principle. also known as the principle of entropy, relates to the irreversibility of a thermodynamic process and proposes the concept of entropy. This principle states that the entropy of a closed system has only two possibilities. either increased, or remained the same', '<ERORR>'),
('Newton''s First Law', 'If an object is not acted upon by any force or is acted upon by a total force of zero, an object at rest will remain at rest forever. and an object in motion will move forever', '<ERORR>'),
  ('Newton''s Third Law', 'When object A exerts a force on object B. then object B also exerts a force on object A in the same direction but in opposite directions; d(Y/X)=M(Y)/M(X)', ''),
  ('Newton''s Second Law', 'The total force on an object is equal to the object''s mass multiplied by its acceleration', '(SUM)F=a*m'),
  ('Ohm''s law of circuits', 'The voltage difference at both ends of the circuit is equal to CDDD multiplied by resistance', '(SUM)R*I=U'),
  ('Ohm''s Law for the whole circuit', 'External circuit voltage equals Electromotive force export minus Potential drop', 'U=E-I.r'),
  ('Hooke''s Law', 'An elastic object will have an elasticity coefficient k', 'F=-kx'),
  ('Law of reflection', 'When light is reflected, the reflected ray will lie in the plane containing the incident ray and the normal of the mirror at the point of incidence. The angle of reflection will be equal to the angle of incidence', 'i''=i'),
  ('Kirchhoff''s First Law', 'In electrical circuits, Kirchhoff''s laws are two equations to describe the relationship between current and voltage. These laws were formulated by Gustav Kirchhoff in 1845', '(SUM) I(k)=0'),
  ('Kirchhoff''s Second Law', 'In electrical circuits, Kirchhoff''s laws are two equations to describe the relationship between current and voltage. These laws were formulated by Gustav Kirchhoff in 1845', '(SUM) V(k)=0'),
  ('Culong''s Law', 'The force of attraction or repulsion between two point charges has a direction that coincides with the straight line connecting those two point charges. has a magnitude proportional to the magnitude of the two charges and inversely proportional to the square of the distance between them', 'F=k*abs(q1*q2)/(r*r)'),
  ('Faraday''s Law of Induction', 'Faraday''s Law of Induction is a fundamental law in electromagnetism, stating that magnetic fields interact with an electric circuit to create electromotive force (EMF) - a phenomenon called electromagnetic induction. That is the basic operating principle of transformers, inductors, electric motors, generators and electromagnets', '(Flux)B=(integral)B(r,t).dA'),
  ('MaxWell Faraday Equation', 'In the case of an inductor with N turns, the formula becomes. In the case of an inductor there are N turns. formula becomes', 'V=-N*(denta)A/(denta)T'),
  ('Law of straight propagation of light', 'Law of straight propagation of light. “In a transparent and uniform medium, light travels in straight lines', '<ERORR>'),
  ('Law of refraction of light', 'Law of refraction of light is explained as follows. The refracted ray always lies in the plane of incidence and on the other side of the normal from the incident ray. The incident plane is the plane formed by the incident ray and the normal. With 2 certain transparent environments. the ratio between sin i and sin r is a constant', 'sin(i)*n(i)=sin(r)*n(r).n=c/v.n21=n2/n1.n1i=n2r'),
  ('Law of light scattering', 'When light passes from one medium to any other medium, for example air, a glass of water, a part of the light is absorbed by particles of the previous medium. Its subsequent radiation is in a specific direction. This phenomenon is called light scattering', '<ERORR>'),
  ('Lorentz''s Law', 'Lorentz force; F=q*(E+v*B)', ''),
  ('Newton''s Law of Universal Gravitation', 'Newton''s law of universal gravitation is often stated. that every particle attracts every other particle .in the universe with a force proportional to the mass product. of them and is inversely proportional to the square of the distance .between their centers.[note 1] The publication of this theory is .called " the first great unification ". for it marks the union of the gravitational phenomena previously described. on Earth with known astronomical behavior', 'F=G*(m1*m2)/(r^2)'),
  ('speed', 'magnitude of velocity', 'V=|v|'),
  ('Acceleration from velocity', 'acceleration is the differential of velocity with respect to time', 'a=dv/dt'),
  ('Uniform acceleration from speed', 'acceleration is the rate of change of velocity', 'v(f)=v(i)+a*t'),
  ('Formula for distance through the east pulley', 'The force through the moving pulley will be reduced by 2 times', 'd''=2*d'),
  ('acceleration from departure','acceleration is the differential of velocity, velocity is the differential of displacement','a= d(dr/dt)/dt'),
  ('uniform acceleration from distance', 'acceleration is the rate of change in speed, speed is the rate of change in distance', 's(f)=s(i)+v(i)*t+*a*(t^2)/2'),
  ('vector of velocity of object thrown obliquely at angle alpha', 'This speed is considered in two directions Ox,Oy', 'v=v(x)+v(y)'),
  ('velocity vector on Ox in the slant throwing problem', 'Project vector v onto Ox', 'v(x)=v*cos(alpha)'),
  ('velocity vector on Oy in the oblique throwing problem', 'Move vector v to Oy', 'v(y)=v*sin(alpha)-gt'),
  ('skeet throwing process time', 'equal to the time taken to throw it vertically upward with velocity v(y)', 't=2*v(y)/g'),
  ('Lorentz force', 'equal to the directional product of two components, B(magnetic induction), v(velocity)', 'f(L)=-eBv'),
  ('Magnetic force', 'equal to the directional product of two components, B(induction), current direction(I)', 'F(F)=-IBl'),
  ('Electrical circuit efficiency', 'Work has product over total work', 'H=A(ci)/A(tp)'),
  ('External circuit capacity', '<many>', 'P=U*I=I^2*R=U^2/R'),
  ('Internal resistance of an electric wire', 'product of output resistance with length above gives cross section', 'R = ρ(l/S)'),
  ('Jun''s theorem', 'heat dissipation', 'Q=I^2Rt'),
  ('First Principle of Thermodynamics', 'It states that the change in energy.inside ΔU of a closed system is equal to the amount of heat Q supplied to the system.minus the amount of work A done by the system on the medium. surrounding field', '<ERORR>'),
  ('Second Law of Thermodynamics', 'Second Law, or second principle. also known as the principle of entropy, relates to the irreversibility of a thermodynamic process and proposes the concept of entropy. This principle states that the entropy of a closed system has only two possibilities. either increased, or remained the same', '<ERORR>'),
  ('proportional error', 'ERORR', 'δA=ΔA/A'),
  ('Law of conservation of mass', 'The following mass must be equal to the original', 'm(i)=mf'),
  ('Principle of conservation of energy', 'energy remains constant before and after the process', 'W(i)=W(f)'),
  ('Law of conservation of momentum', 'Momentum will be conserved if there is no impulse', 'Σmi*vi=Σmf*vf'),
  ('Nuclear energy', '', 'E=m*c^2. (m is the particle mass). c=3*10^8 (m/s) is the speed of light'),
  ('Radiant energy', '', 'W=hc/λ=hf. (c is the speed of light). h is the botzman constant. λ is the wave of light. f is the frequency of light'),
  ('Pressure in the liquid', 'p=dgh. where d is the density of the liquid. g is the gravitational acceleration. h is the depth', ''),
  ('Law of pressure balance', 'In liquid and gas environments, the pressure at two points of equal height will be equal', 'erorr'),
  ('Formula II New Ton', '"The combination of force vectors is equal to the product of acceleration and mass vectors"', '(SUM)F=m*a'),
  ('Lever arm formula', '"Give me a fulcrum and I''ll be able to play this game"', 'F1/F2=d1/d2'),
  ('Newton''s Third Law', '"When a force is applied to an object, that object will exert a reaction force of equal magnitude"', 'F1=F2'),
  ('Formula for force through the east pulley', 'The force through the movable pulley will be reduced by 2 times', 'F''=F/2'),
  ('Formula of force through n movable pulleys', 'force through n movable pulleys decreases by 2^n times', 'F''=F/(2^n)'),
  ('Formula for distance through n movable pulleys', 'force through n movable pulleys decreases by 2^n times', 'd''=d*2^n'),
  ('Looseness formula', 'The displacement vector is equal to the directional product of the velocity vector multiplied by time', 'r=v*t'),
  ('Distance formula', 'Distance equals average speed and time', 's=v*t');


  Insert into MathematicalTheorem (Type,Name,FORMULA) Values
('Algebra', 'Inequality formula', 'a>b+c <=> a-c>b'),
('Algebra', 'Cozy Inequality', '(a1+a2+...+an) >= sqrt((a1*a2*a3...a*n),1/n) first occurs when a1=a2=a3...=an'),
('Algebra', 'Inequalities that treat absolute value signs |...|', '|a+b|<=|a|+|b| , ||a|+|b||<=|a-b|, "==" occurs when a*b>=0'),
('Algebra', 'Inequalities curing the five-two sign', 'x^2 >= 0'),
('Algebra', 'Common inequality', '(a^2+b^2)(x^2+y^2)>=(a*x+b*y)^2 (x,y,a,b in R)'),
('Algebra', 'Bunhacopski inequality', '(a(1)^2+a(2)^2+...a(n)^2)*(b(1)^2+b(2)^2+...b(n)^2 )>=(a(1)*b(1)+a(2)*b(2)...a(n)*b(n))^2'),
('Algebra', 'Common inequality', 'a>b>0, c>d>0 =>ac>bd'),
('Algebra', 'Common inequality', 'a>b>0, 1/a < 1/b'),
('Algebra', 'Common inequality', 'a>b>0 => a^n>b^n (n > 0)'),
('Algebra', 'Common inequality', 'a>b>0 => sqrt(a,n) > sqrt(b,n) ( n>=0 )'),
('Geometry', 'Calculate the area of a circle', 'S=π*r^2'),
('Geometry', 'Calculate the area of a square', 'S=r^2'),
('Geometry', 'Calculate the area of a rectangle', 'S=a*b'),
('Geometry', 'Calculate the area of a triangle', 'S=1/2*a*b*sin(C)=1/2*b*c*sin(A)=1/2*a*c*sin(B)'),
('Geometry', 'Calculate the circumference of a circle', '2p=π*r*2'),
('Geometry', 'Calculate the perimeter of a triangle', '2p=a+b+c'),
('Geometry', 'Calculate the perimeter of a square', '2p=4*a'),
('Geometry', 'Calculate the area of a triangle', 'S=sqrt(p*(p-a)*(p-b)*(p-c)) where p is the half circumference'),
('Geometry', 'Calculate the perimeter of a rectangle', 'p=a+b'),
('Geometry', 'Angle 180C', '180(c)=π (radian)'),
('Geometry', 'Angle 1C', '1C=π/180(radian) => 1 (rad) = 180/π'),
('Geometry', 'tan(a)', 'tan(a)=sin(a)/cos(a)'),
('Geometry', 'tan(a)_2', '1+tan(a)^2=1/(cos(a)^2)'),
('Geometry', 'cotan(a)_2', '1+cotan(a)^2=1/(sin(a)^2)'),
('Geometry', 'sin(a),cos(a)', 'sin(a)^2+cos(a)^2=1'),
('Geometry', 'Trigonometric expression', 'sin(a)^4+cos(a)^4=1-1/2*sin(2*x)^2'),
('Geometry', 'Trigonometric expression', 'sin(x)^6+cos(x)^6=1-3/4*sin(2*x)^2'),
('Geometry', 'Trigonometric expression', '-1<sin(x)<1'),
('Geometry', 'Trigonometric expression', '-1<cos(x)<1'),
('Geometry', 'Trigonometric expression', 'cos(-a)=cosa, sin(-a)=-sin(a)'),
('Geometry', 'Trigonometric expression', 'tan(-a)=-tan(a), cotan(-a)=-cotan(a)'),
('Geometry', 'Trigonometric expression', 'sin(π - a) = sin(a), cos(π - a)=-cos(a)'),
('Geometry', 'Trigonometric expression', 'tan(π-a)=-tan(a),cotan(π-a)=-cotan(a)'),
('Geometry', 'Trigonometric expression', 'sin(a)+sin(b)=2*sin((a+b)/2)*cos((a-b)/2)'),
('Geometry', 'Trigonometric expression', 'sin(a)-sin(b)=2*sin((a+b)/2)*sin((a-b)/2)'),
('Geometry', 'Trigonometric expression', 'cos(a)+cos(b)=2*cos((a+b)/2)*cos((a-b)/2)'),
('Geometry', 'Trigonometric expression', 'cos(a)-cos(b)=-2*sin((a+b)/2)*sin((a-b)/2)'),
('Geometry', 'Trigonometric expression', 'tan(a)+tan(b)=sin(a+b)/(cos(a)*cos(b))'),
('Geometry', 'Trigonometric expression', 'tan(a)-tan(b)=sin(a-b)/(cos(a)*cos(b))'),
('Geometry', 'Trigonometric expression', 'sin(x)+cos(x)=sqrt(2)*sin(x-π/4)'),
('Geometry', 'Trigonometric expression', 'sin(x)-cos(x)=-sqrt(2)*sin(x+π/4)'),
('Geometry', 'Downgrade_1', 'cos(2*x)=2*cos(x)^2-1=1-2*sin(x)^2'),
('Geometry', 'Downgrade_2', 'sin(2*x)=2*sin(x)*cos(x)'),
('Geometry', '2nd order trigonometric equation', 'a*sin(x)^2+b*sin(x)*cos(x)+cos(x)^2=d'),
('Geometry', 'Trigonometric equation of degree 1', 'a*sin(x)+b*cos(x)=c (a^2+b^2>c^2)'),
('Geometry', 'Symmetric and anti-symmetric equations', 'a*(sin(x)+cos(x))+b*sin(x)*cos(x)+c=0'),
('Algebra', 'Addition rule, when two events are completely different', 'm1+m2+m3...'),
('Algebra', 'Multiplication rule, when two events are related', 'm1*m2*m3...'),
('Algebra', 'Permutation of n elements', 'Number of ways to arrange n elements into n different positions, P(n)=n!'),
('Algebra', 'Combination of input k of n elements', 'has n elements and k places, number of ways to tell the positions;A(k,n)=P(k,n)=n(A)k'),
('Algebra', 'Convolution k of n elements', 'there are n elements, number of ways to arrange n in k places (not including positions);nCk'),
('Algebra', 'Newton Binomial', '(a+b)^n=nC0*a^n*b^0+nC1*a^n-1*b^1+...+nCn*a^0*b^n'),
('Algebra', 'Probability', 'P| Ω |=1, P(A)=A/|Ω|');