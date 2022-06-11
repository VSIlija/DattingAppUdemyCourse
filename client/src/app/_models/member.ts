import { lookingForCategory } from "./lookingForCategory";
import { Photo } from "./photo";

export interface Member{
    id: number;
    firstName: string;
    lastName: string;
    fullName: string;
    username: string;
    email: string;
    photoUrl: string;
    age: number;
    height: number;
    job: string;
    company: string;
    education: string;
    children: string;
    dateOfBirth: Date;
    knownAs: string;
    created: Date;
    lastActive: Date;
    gender: string;
    lookingFor: string;
    introduction: string;
    interests: string;
    city: string;
    country: string;
    drinking: string;
    relationship: string;
    smoking: string;
    sexuality: string;
    starSign: string;
    religion: string;
    personality: string;
    whyYouAreHere: string;
    school: string;
    lookingForCheckboxValues: lookingForCategory[];
    photos: Photo[];
}

